#include <WiFi.h>
#include <WebServer.h>
#include <ESP32Servo.h>

const char* ssid = "YOUR_WIFI";
const char* password = "YOUR_PASSWORD";

WebServer server(80);

Servo lockServo;

#define SERVO_PIN 13

bool unlocked = false;

void unlockDoor() {

  unlocked = true;

  Serial.println("UNLOCK");

  lockServo.write(90);

  delay(5000);

  lockServo.write(0);

  unlocked = false;

  server.send(200, "text/plain", "Door Opened");
}

void statusDoor() {

  if(unlocked) {
    server.send(200, "text/plain", "OPEN");
  } else {
    server.send(200, "text/plain", "LOCK");
  }
}

void setup() {

  Serial.begin(115200);

  lockServo.attach(SERVO_PIN);

  lockServo.write(0);

  WiFi.begin(ssid, password);

  while(WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }

  Serial.println("");
  Serial.println(WiFi.localIP());

  server.on("/unlock", unlockDoor);

  server.on("/status", statusDoor);

  server.begin();
}

void loop() {
  server.handleClient();
}
