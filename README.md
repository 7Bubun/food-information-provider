# Aplikacja wspomagająca zdrowe odżywianie się
Projekt zaliczeniowy nr 1 na zajęcia z przedmiotu "Wprowadzenie do aplikacji i rozwiązań opartych o Sztuczną Inteligencję i Microsoft Azure".

## Opis projektu
Głównym założeniem projektu jest ułatwienie prowadzenia zdrowego trybu odżywiania się poprzez stworzenie aplikacji potafiącej dostarczać informacje o danych produktach spożywczych na podstawie załączonego przez użytkownika zdjęcia.

## Zespół
- Kacper Hołubowicz https://github.com/KacperHolubowicz
- Jakub Grenda https://github.com/7Bubun

## Opis funkcjonalności
Aplikacja na podstawie dostarczonego przez użytkownika zdjęcia zawierającego produkty żywnościowe wyświetla użytkownikowi informacje na temat wykrytych na obrazie artykułów spożywczych takie jak: przybliżona kaloryczność, pozytywne i negatywne właściwości odżywcze oraz ewentualny produkt zastępczy (jeśli istnieje zdrowsza alternatywa).

## Schemat działania 
1. Aplikacja przyjmuje od użytkownika obrazek.
2. Aplikacja rozpoznaje produkty spożywcze znajdujące się na obrazie.
3. Aplikacja pobiera informacje o produkdach z bazy danych.
4. Aplikacja wyświetla użytkownikowi informacje o produktach.

## Architektura
![azure_architecture_proj1](https://user-images.githubusercontent.com/62255561/140769572-5de7527d-3f95-4a54-bb62-13d83230c3f4.jpg)

## Stos technologiczny
- App service
- SQL Database
- Cognitive Service (Custom Vision)
- Container Instances i/lub Logic Apps
- .NET

## Zakres prac
- utworzenie usługi typu Custom Vision
- zgromadzenie danych (w formie obrazów) potrzebnych do wytrenowania modelu Custom Vision
- wytrenowanie modelu w usłudze Custom Vision
- utworzenie i konfiguracja bazy danych
- zgromadzenie danych o produktach i umieszczenie ich w bazie danych
- napisanie aplikacji webowej do interakcji z użytkownikiem
- utworzenie i konfiguracja App Service oraz wdrożenie aplikacji
- wdrożenie modelu Custom Vision za pomocą Container Instances i/lub Logic Apps
