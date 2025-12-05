# Changelog

Wszystkie istotne zmiany w tym projekcie będą zapisywane w tym pliku.
Format oparty jest na "Keep a Changelog" — sekcja `Unreleased` służy do prac w toku,
a kolejne sekcje zawierają wydania powiązane z tagami Git.

## [Unreleased]
- Prace deweloperskie — lista zmian przed kolejnym wydaniem.

## [0.0.0] - 2025-12-02
- Pierwsze lokalne wydanie oznaczone jako `v0.0.0`.
- Dodano podstawowy interfejs: górna belka i stopka, wyświetlanie daty/godziny.

## [0.0.1] - 2025-12-03
- Kolejne lokalne wydanie oznaczone jako `v0.0.1`.
- W StartView dodano 6 przycisków do zmiany widoków zdefiniowanych w folderze "Views"
	- AlarmView
	- KameryView
	- DomofonView
	- OswietlenieView
	- RoletyView
	- TemperaturaView
- W każdym z zdefiniowanych widoków dodano przyciski powrotu do StartView.
- Dodano podstawowe style CSS dla przycisków i widoków.
- Zaktualizowano dokumentację projektu.

## [0.0.2] - 2025-12-05
- Kolejne lokalne wydanie oznaczone jako `v0.0.2`.
- Projekt połączony z repozytorium GitHub https://github.com/pawelstanisz/StaniszkiSmartHome

## [0.0.3] - 2025-12-05
- Kolejne lokalne wydanie oznaczone jako `v0.0.3`.
- Dodano nowy widok StartupView z grafiką umieszczoną w resources/images/StaniszkiDomWidok.png
- Widok StartupView ustawiony jako domyślny przy uruchomieniu aplikacji.
- Dodano przycisk "Start" na widoku StartupView, który przełącza na StartView.
- Po kliknięciu w LogoText w górnej belce, aplikacja przełącza się na widok StartupView.