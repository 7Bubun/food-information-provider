# Aplikacja wspomagająca zdrowe odżywianie się
Projekt zaliczeniowy nr 1 na zajęcia z przedmiotu "Wprowadzenie do aplikacji i rozwiązań opartych o Sztuczną Inteligencję i Microsoft Azure".

## Opis projektu
Głównym założeniem projektu jest ułatwienie prowadzenia zdrowego trybu odżywiania się poprzez stworzenie aplikacji potafiącej dostarczać podstawowe informacje o produktach spożywczych znajdujących się na załączonym przez użytkownika zdjęciu.

## Zespół
- Kacper Hołubowicz https://github.com/KacperHolubowicz
- Jakub Grenda https://github.com/7Bubun

## Opis funkcjonalności
Aplikacja na podstawie dostarczonego przez użytkownika zdjęcia zawierającego produkty żywnościowe wyświetla użytkownikowi informacje na temat wykrytych na obrazie artykułów spożywczych takie jak: przybliżona kaloryczność, pozytywne i negatywne właściwości odżywcze oraz dodatkowe informacje np. ewentualny produkt zastępczy.

## Schemat działania 
1. Aplikacja przyjmuje od użytkownika obrazek.
2. Aplikacja rozpoznaje produkty spożywcze znajdujące się na obrazie.
3. Aplikacja pobiera informacje o produktach z bazy danych.
4. Aplikacja wyświetla użytkownikowi informacje o produktach.

## Architektura
![azure_arch_proj1_v2](https://user-images.githubusercontent.com/62255561/140944571-dc086a48-c6ce-462b-a667-a94ddb02fb8d.jpg)

## Stos technologiczny
- App service
- SQL Database
- Cognitive Service (Custom Vision)
- .NET

## Zakres prac
- utworzenie usługi typu Custom Vision
- zgromadzenie danych (w formie obrazów) potrzebnych do wytrenowania modelu Custom Vision
- wytrenowanie modelu w usłudze Custom Vision
- utworzenie i konfiguracja bazy danych
- zgromadzenie danych o produktach i umieszczenie ich w bazie danych
- napisanie aplikacji webowej do interakcji z użytkownikiem
- utworzenie i konfiguracja App Service oraz wdrożenie aplikacji

## Podział zadań
- Przygotowanie grupy zasobów - Jakub Grenda
- Custom Vision
  - zgromadzenie danych potrzebnych do trenowania modelu - Jakub Grenda oraz Kacper Hołubowicz
  - otagowanie poszczególnych produktów na znalezionych obrazkach - Jakub Grenda oraz Kacper Hołubowicz
  - przeprowadzenie testów dokładności poszczególnych iteracji - Jakub Grenda oraz Kacper Hołubowicz
- SQL Database
  - znalezienie informacji o produktach żywnościowych obsługiwanych przez aplikację - Jakub Grenda
  - przygotowanie skryptów sql inicjujących bazę danych - Jakub Grenda
- App Service
  - przygotowanie logiki aplikacji webowej (komunikacja z modelem Custom Vision i bazą danych) - Kacper Hołubowicz
  - przygotowanie warstwy graficznego interfejsu użytkownika - Jakub Grenda oraz Kacper Hołubowicz
  - wdrożenie aplikacji na Azure App Service - Jakub Grenda oraz Kacper Hołubowicz
 
