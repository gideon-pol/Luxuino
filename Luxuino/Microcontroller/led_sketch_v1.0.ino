#include <EEPROM.h>

class Color{
  public:
    float Red;
    float Green;
    float Blue;
};

Color currentColor;
//String command;
char commandC[350];
int cIndex = 0;

bool canReactToAudio = false;
Color audioColorFrom, audioColorTo;

bool canReactToScreen = false;
int screenInterval;

int redPin = 10;
int greenPin = 11;
int bluePin = 9;

void setup() {
  Serial.begin(38400);
  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);
  while(!Serial);
  Serial.setTimeout(10);
  if(EEPROM.read(0) == 99){
    byte b;
    int i = 1;
    char command[350];
    while((b=EEPROM.read(i)) != 255){
      command[i-1] = (char)b;
      i++;
    }
    parseLedMode(command);
  }
}
void loop(){
  if(Serial.available()){
    char c = Serial.read();
    if(c == '\n')
    {
      parseLedMode(commandC);
      Serial.flush();
      memset(commandC, 0, 350);
      cIndex = 0;
    } else 
    {
      commandC[cIndex] = c;
      cIndex++;
    }
  }
}

void parseLedMode(char* command){
  char* chars = command;
  char* str;
  int i = 0;
  char* incoming_data[3];
  while((str= strtok_r(chars, ":", &chars)) != NULL){
    incoming_data[i] = str;
    if(strcmp(str, "save")==0){
      incoming_data[1] = chars;
      break;
    }
    i++;    
  }
  if(strcmp(incoming_data[0], "st") == 0){
    canReactToAudio = false;
    canReactToScreen = false;
    Color c = GetColor(incoming_data[1]);
    ColorChange(c, currentColor, 250);
  } 
  else if(strcmp(incoming_data[0], "br") == 0){
     canReactToAudio = false;
     canReactToScreen = false;
     Color c = GetColor(incoming_data[1]);
     BreathingPattern(c, atof(incoming_data[2]));
  } 
  else if(strcmp(incoming_data[0], "ra") == 0){
    canReactToAudio = false;
    canReactToScreen = false;
    RainbowPattern(atof(incoming_data[1]));
  } 
  else if(strcmp(incoming_data[0], "se") == 0){
    canReactToAudio = false;
    canReactToScreen = false;
    SequencePattern(incoming_data[1], atof(incoming_data[2]));
  } 
  else if(strcmp(incoming_data[0], "save") == 0){
    EEPROM.write(0, 99);
    for(int i = 1; i<strlen(incoming_data[1])+1; i++){
      EEPROM.write(i, incoming_data[1][i-1]);
    }
    EEPROM.write(strlen(incoming_data[1])+1, 255);
    parseLedMode(incoming_data[1]);
  }
  else if(strcmp(incoming_data[0], "i") == 0){
    canReactToAudio = false;
    canReactToScreen = false;
    return;
  } else if(strcmp(incoming_data[0], "au") == 0){
    canReactToScreen = false;
    canReactToAudio = true;
    AudioPattern(incoming_data[1]);
  } else if(strcmp(incoming_data[0], "sc") == 0){
    canReactToAudio = false;
    canReactToScreen = true;
    screenInterval = atoi(incoming_data[1]);
  } else if(canReactToAudio){
    if(isDigit(incoming_data[0][0])){
        Audio(atoi(incoming_data[0]));
    }
  } else if(canReactToScreen){
    Color c = GetColor(incoming_data[0]);
    ColorChange(c, currentColor, screenInterval);
  }
}

void BreathingPattern(Color color, float PulsesPerSecond){
  ColorChange(GetColor("0,0,0"), currentColor, 250);
  float wait = 1/PulsesPerSecond/2/250*1000;
  while(true){
    for (int i = 0; i < 250; i++) {
      analogWrite(redPin, color.Red * i/250);
      analogWrite(greenPin, color.Green* i/250);
      analogWrite(bluePin, color.Blue* i/250);
      delay(wait);
      if(Serial.available()){
        Color c;
        c.Red = color.Red* i/250;
        c.Green = color.Green* i/250;
        c.Blue = color.Blue* i/250;
        currentColor = c;
        return;
      }
    }
    for (int i = 250; i > 0; i--) {
      analogWrite(redPin, color.Red* i/250);
      analogWrite(greenPin, color.Green* i/250);
      analogWrite(bluePin, color.Blue* i/250);
      delay(wait);
      if(Serial.available()){
        Color c;
        c.Red = color.Red* i/250;
        c.Green = color.Green* i/250;
        c.Blue = color.Blue* i/250;
        currentColor = c;
        return;
      }
    }
  }
}

void RainbowPattern(float CycleLength){
  ColorChange(GetColor("255,0,0"), currentColor, 250);
  float wait = CycleLength/360*1000;
  while(true){
    for(int i = 0; i<360; i++){
      Color color = hsv2rgb(i, 1, 1);
      analogWrite(redPin, color.Red);
      analogWrite(greenPin, color.Green);
      analogWrite(bluePin, color.Blue);
      delay(wait);
      if(Serial.available()){
        currentColor = color;
        return;
      }
    }
  }
}

void SequencePattern(char* sequence, float totalLength){
  int totalSequenceSize = 0;
  for(int i = 0; i<strlen(sequence); i++){
      if(sequence[i] == '|'){
        totalSequenceSize++;
      }
  }
  
  while(true){
    char d[strlen(sequence)];
    memcpy(d, sequence, strlen(sequence));
    char *buf = d;
    char *str;
    String currentString;
    if((str= strtok_r(buf, "|", &buf)) != NULL){
      currentString = str;   
    }
    
    ColorChange(GetColor(currentString.substring(0, currentString.indexOf(";"))), currentColor, 250);
    for(int i = 0; i<totalSequenceSize-1; i++){
      String nextString;
      if((str= strtok_r(buf, "|", &buf)) != NULL){
        nextString = str;   
      }
      Color colorNext = GetColor(nextString.substring(0, nextString.indexOf(";")));
      
      float timePositionCurrent = currentString.substring(currentString.indexOf(";")+1).toFloat();
      float timePositionNext = nextString.substring(nextString.indexOf(";")+1).toFloat();
      ColorChange(colorNext, currentColor, (timePositionNext-timePositionCurrent)*totalLength * 1000);
      
      currentString = nextString;
      if(Serial.available())
          return;
    }
  }
}

void AudioPattern(char* colors){
  char *str;
  if((str= strtok_r(colors, "|", &colors)) != NULL){
    audioColorFrom = GetColor(str);   
  }
  if((str= strtok_r(colors, "|", &colors)) != NULL){
    audioColorTo = GetColor(str);   
  }
}

void Audio(float audioLevel){
  audioLevel/=100;
  float redDifference = audioColorTo.Red - audioColorFrom.Red;
  float greenDifference = audioColorTo.Green - audioColorFrom.Green;
  float blueDifference = audioColorTo.Blue - audioColorFrom.Blue;
  Color outputColor;
  outputColor.Red = audioColorFrom.Red+redDifference*audioLevel;
  outputColor.Green = audioColorFrom.Green+greenDifference*audioLevel;
  outputColor.Blue = audioColorFrom.Blue+blueDifference*audioLevel;
  ColorChange(outputColor, currentColor, 30);
}

void ClearScreenAndAudio(){
  canReactToAudio = false;
  canReactToScreen = false;
  memset(screenInterval, 0, 0);
}

Color hsv2rgb(float h, float s, float v) {
  Color color;
  color.Red = abs(v - (v * s * max(min(fmod(5.0+(h/60.0), 6.0), min(4.0 - (fmod(5.0+(h/60.0), 6.0)), 1.0)), 0.0))) * 255;
  color.Green = abs(v - (v * s * max(min(fmod(3.0+(h/60.0), 6.0), min(4.0 - (fmod(3.0+(h/60.0), 6.0)), 1.0)), 0.0))) * 255;
  color.Blue = abs(v - (v * s * max(min(fmod(1.0+(h/60.0), 6.0), min(4.0 - (fmod(1.0+(h/60.0), 6.0)), 1.0)), 0.0))) * 255;
  return color;
}

Color GetColor(String input){
  input += '\0';
  char buf[input.length()];
  input.toCharArray(buf, input.length());
  char *chars = buf;
  Color c;
  c.Red = atof(strtok(chars, ","));
  c.Green = atof(strtok(NULL, ","));
  c.Blue = atof(strtok(NULL, ","));
  return c;
}

void ColorChange(Color to, Color from, float len) {
  float divider = 250;
  float wait;
  if(len<250){
    divider = max(len, 1);
    wait = 1;
  } else {
    wait = len/250;
  }

  float redChange = (to.Red - from.Red) / divider;
  float greenChange = (to.Green - from.Green) / divider;
  float blueChange = (to.Blue - from.Blue) / divider;

  for (int i = 0; i < (int)divider; i++) {
    from.Red += redChange;
    from.Green += greenChange;
    from.Blue += blueChange;
    analogWrite(redPin, from.Red);
    analogWrite(greenPin, from.Green);
    analogWrite(bluePin, from.Blue);
    currentColor.Red = from.Red;
    currentColor.Green = from.Green;
    currentColor.Blue = from.Blue;
    delay((int)wait);
    if(Serial.available())
          return;
  }
}

