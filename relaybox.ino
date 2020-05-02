const int conPins[] = {2,3,4,5,6,7,8,9,10,11};
//pins 2 & 3 (conPins[0,1]) for RLY CH1
//pins 4 & 5 (conPins[2,3]) for RLY CH2
//pins 6 & 7 (conPins[4,5]) for RLY CH3
//pins 8 & 9 (conPins[6,7]) for RLY CH4
//pins 10 & 11 (conPins[8,9]) for RLY CH5
int lenConPin = sizeof(conPins)/sizeof(conPins[0]);
int i = 0;
String serialIn = "";

void setup() {
  // put your setup code here, to run once:
  for(i=0;i<lenConPin;i++){
    pinMode(conPins[i],OUTPUT);
  }
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  while(Serial.available()>0){
    serialIn = Serial.readStringUntil('\n');
    serialIn.toUpperCase();
    //Serial.print(serialIn);
    if(serialIn == "L1"){
      Serial.println("Low Side CH1");
      digitalWrite(conPins[0],LOW);
      digitalWrite(conPins[1],LOW);
      digitalWrite(conPins[0],HIGH);
    }
    else if(serialIn == "H1"){
      Serial.println("High Side CH1");
      digitalWrite(conPins[0],LOW);
      digitalWrite(conPins[1],LOW);
      digitalWrite(conPins[1],HIGH);
    }
    else if(serialIn == "L2"){
      Serial.println("Low Side CH2");
      digitalWrite(conPins[2],LOW);
      digitalWrite(conPins[3],LOW);
      digitalWrite(conPins[2],HIGH);
    }
    else if(serialIn == "H2"){
      Serial.println("High Side CH2");
      digitalWrite(conPins[2],LOW);
      digitalWrite(conPins[3],LOW);
      digitalWrite(conPins[3],HIGH);
    }
    else if(serialIn == "L3"){
      Serial.println("Low Side CH3");
      digitalWrite(conPins[4],LOW);
      digitalWrite(conPins[5],LOW);
      digitalWrite(conPins[4],HIGH);
    }
    else if(serialIn == "H3"){
      Serial.println("High Side CH3");
      digitalWrite(conPins[4],LOW);
      digitalWrite(conPins[5],LOW);
      digitalWrite(conPins[5],HIGH);
    }
    else if(serialIn == "L4"){
      Serial.println("Low Side CH4");
      digitalWrite(conPins[6],LOW);
      digitalWrite(conPins[7],LOW);
      digitalWrite(conPins[6],HIGH);
    }
    else if(serialIn == "H4"){
      Serial.println("High Side CH4");
      digitalWrite(conPins[6],LOW);
      digitalWrite(conPins[7],LOW);
      digitalWrite(conPins[7],HIGH);
    }
    else if(serialIn == "L5"){
      Serial.println("Low Side CH5");
      digitalWrite(conPins[8],LOW);
      digitalWrite(conPins[9],LOW);
      digitalWrite(conPins[8],HIGH);
    }
    else if(serialIn == "H5"){
      Serial.println("High Side CH5");
      digitalWrite(conPins[8],LOW);
      digitalWrite(conPins[9],LOW);
      digitalWrite(conPins[9],HIGH);
    }
    else if(serialIn == "ALLO"){
      Serial.println("All Low Side ON");
      for(i = 0; i< lenConPin;i++){
        digitalWrite(conPins[i],LOW);
      }
      for(i = 0; i< lenConPin;i+=2){
        digitalWrite(conPins[i],HIGH);
      }
    }
    else if(serialIn == "ALHI"){
      Serial.println("All High Side ON");
      for(i = 0; i< lenConPin;i++){
        digitalWrite(conPins[i],LOW);
      }
      for(i = 1; i< lenConPin;i+=2){
        digitalWrite(conPins[i],HIGH);
      }
    }
    else if(serialIn == "TESTCON"){
      Serial.println("Arduino connected");
    }
    else{
      Serial.println("All RESET");
      for(i = 0; i< lenConPin;i++){
        digitalWrite(conPins[i],LOW);
      }
    }
  }
}
