  /*
      ------ Waspmote Pro Code Example --------
  
      Explanation: This is the basic Code for Waspmote Pro
  
      Copyright (C) 2016 Libelium Comunicaciones Distribuidas S.L.
      http://www.libelium.com
  
      This program is free software: you can redistribute it and/or modify
      it under the terms of the GNU General Public License as published by
      the Free Software Foundation, either version 3 of the License, or
      (at your option) any later version.
  
      This program is distributed in the hope that it will be useful,
      but WITHOUT ANY WARRANTY; without even the implied warranty of
      MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      GNU General Public License for more details.
  
      You should have received a copy of the GNU General Public License
      along with this program.  If not, see <http://www.gnu.org/licenses/>.
       *  Version:           0.1
       *  Design:            Agustí Trullén 
       *  Implementation:    Agustí Trullén 
   
  */
  
  #include <WaspXBee868.h>
  #include <WaspFrame.h>
  #include <DHT.h>
  
  // define variable
  uint8_t error;
  
  
  // Humidity and Temperature sensor variables
  #define DHTTYPE DHT22 // DHT 22  (AM2302), AM2321
  const int DHTPin = DIGITAL8;    // what digital pin we're connected to
  
  
  // Define Waspmote Gateway MAC address
  //////////////////////////////////////////
  char RX_ADDRESS[] = "0013A200408B55AC";
  //////////////////////////////////////////
  
  // Define the Waspmote ID
  char WASPMOTE_ID[] = "node_02";
  
  //DHT function
  DHT dht(DHTPin, DHTTYPE);
  
  void setup() {
  
     dht.begin();   //Init sensor dht
     USB.ON();
     
     PWR.setSensorPower(SENS_3V3,SENS_ON);    //Power on 3v pin 
     PWR.setSensorPower(SENS_5V,SENS_ON);     //Power on 5v pin
  
     // store Waspmote identifier in EEPROM memory
     frame.setID( WASPMOTE_ID );
     // init XBee
     xbee868.ON();
  
     RTC.ON();
     // Setting time [yy:mm:dd:dow:hh:mm:ss]
     RTC.setTime("22:06:16:05:00:40:00");
  }
  
  void loop() {
     // Wait a few seconds between measurements.
     delay(2000);
     
     float h = dht.readHumidity();    //Read humidity 
     float t = dht.readTemperature();   //Read temperature
     int l = analogRead(ANALOG3);   //Read light level
  
       if (isnan(h) || isnan(t)) {    
          USB.println("Faled to read from DHT sensor!"); //Lecture Error
          return;      
       }
     
     //Print measures
     USB.print("Ligth Level: ");
     USB.print(l);
     USB.print(" %\t");
     USB.print("Humidity: ");
     USB.print(h);
     USB.print(" %\t");
     USB.print("Temperature: ");
     USB.print(t);
     USB.print(" *C ");
     USB.print(" %\n");
  
    
     ///////////////////////////////////////////
    // 1. Create ASCII frame
    ///////////////////////////////////////////  
    USB.println(F("Sending packet..."));
    // create new frame
    frame.createFrame(ASCII);  
    
    // add frame fields
    frame.addSensor(SENSOR_STR, RTC.getTime());
    frame.addSensor(SENSOR_BAT, PWR.getBatteryLevel()); 
    frame.addSensor(SENSOR_BME_HUM, h); 
    frame.addSensor(SENSOR_BME_TC, t); 
    frame.addSensor(SENSOR_LUXES, l); 
  
    ///////////////////////////////////////////
    // 2. Send packet
    ///////////////////////////////////////////  
  
    // send XBee packet
    error = xbee868.send( RX_ADDRESS, frame.buffer, frame.length );   
    
    // check TX flag
  if( error == 0 )
  {
    USB.println(F("send ok"));
    
    // blink green LED
    Utils.blinkGreenLED();    
  }
  else 
  {
    USB.println(F("send error"));
    
    // blink red LED
    Utils.blinkRedLED();
  }

  // wait for five seconds
  delay(60000);
}
