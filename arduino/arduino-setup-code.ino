// Arduino config for IKEA LED Dioder
// demo set up 

// PIN definition:
int ledPinR = 9; 	//Red
int ledPinG = 11; 	//Green
int ledPinB = 10; 	//Blue

// initial setup
void setup()  {
pinMode(ledPinR, OUTPUT);
pinMode(ledPinG, OUTPUT);
pinMode(ledPinB, OUTPUT);

Serial.begin(9600);
}

// program - interaction interface
void loop() {
	if (Serial.available() > 0) {
    int inByte = Serial.read();
  
  switch (inByte) {
    
      // red
   case 'a':    
      analogWrite(ledPinR, 255);
      analogWrite(ledPinG,0);
      analogWrite(ledPinB, 0);
      break;
      // pink
   case 'b':
      analogWrite(ledPinR, 255);
      analogWrite(ledPinG,0);
      analogWrite(ledPinB, 255);   
      break;
   case 'c':
      // yellow
      analogWrite(ledPinR, 255);
      analogWrite(ledPinG, 255);
      analogWrite(ledPinB, 0);
      break;
   case 'd':
      // white   
      analogWrite(ledPinR, 255);
      analogWrite(ledPinG, 255);
      analogWrite(ledPinB, 255);
      break;
   case 'e':
     // green
      analogWrite(ledPinR, 0);
      analogWrite(ledPinG,255);
      analogWrite(ledPinB, 0);  
      break;
   case 'f':
     // teal
      analogWrite(ledPinR, 0);
      analogWrite(ledPinG,255);
      analogWrite(ledPinB,255);  
      break;
   case 'g':
     // blue
      analogWrite(ledPinR, 0);
      analogWrite(ledPinG,0);
      analogWrite(ledPinB,255);  
      break;
    case 'p':
     // off
      analogWrite(ledPinR,0);
      analogWrite(ledPinG,0);
      analogWrite(ledPinB,0);  
      break;      
  case 'h':
      analogWrite(ledPinR, 255);
      analogWrite(ledPinG, 0);
      analogWrite(ledPinB, 0);
      delay(500);
      analogWrite(ledPinR, 0);
      analogWrite(ledPinG, 255);
      analogWrite(ledPinB, 255);
      delay(200);
      analogWrite(ledPinR, 0);
      analogWrite(ledPinG,0);
      analogWrite(ledPinB, 255);
      delay(200);
      analogWrite(ledPinR, 0);
      analogWrite(ledPinG, 255);
      analogWrite(ledPinB, 255);
      delay(200);
      analogWrite(ledPinR, 0);
      analogWrite(ledPinG, 0);
      analogWrite(ledPinB, 255);
      delay(200);
      break;
   case 'o':
      for (int i=0; i <= 255; i++){
      analogWrite(ledPinR, i);
      delay(10);
   } 
  break; 
 case 'r':
      for (int i=255; i >= 0 ; i = i - 1){
      analogWrite(ledPinR, i);
      delay(10);
   } 
  break;   
  
      
 default:
      // turn all the LEDs off:
      analogWrite(ledPinR, 0);
      analogWrite(ledPinG, 0);
      analogWrite(ledPinB, 0);
    } 
  }
}
