# PocketReader

PocketReader ist eine plattformübergreifende **.NET MAUI**-App zum Speichern und Verwalten von Bookmarks/„Read-later“-Inhalten.  
Die App nutzt ein **MVVM-Pattern**, speichert Daten lokal per **SQLite** und bindet zusätzlich einen **PocketBase-Client** ein.

## Features

- Bookmarks anlegen, anzeigen und verwalten
- Kategorien zur Organisation von Inhalten
- Lokale Persistenz mit SQLite
- Multi-Plattform-Unterstützung über .NET MAUI:
  - Android
  - iOS
  - MacCatalyst
  - Windows
  - Tizen

## Tech-Stack

- **C# / .NET 9**
- **.NET MAUI**
- **CommunityToolkit.Mvvm**
- **SQLite-net-pcl**
- **PocketBaseClient**

## Projektstruktur

```text
PocketReader/
├─ PocketReader.sln
└─ PocketReader/
   ├─ App.xaml
   ├─ AppShell.xaml
   ├─ MainPage.xaml
   ├─ MauiProgram.cs
   ├─ PocketReader.csproj
   ├─ Models/
   │  └─ Bookmark.cs
   ├─ ViewModels/
   │  └─ BookmarkViewModel.cs
   ├─ Views/
   │  ├─ BookmarkViewPage.xaml
   │  └─ BookmarkViewPage.xaml.cs
   ├─ Resources/
   ├─ Properties/
   └─ Platforms/
      ├─ Android/
      ├─ iOS/
      ├─ MacCatalyst/
      ├─ Windows/
      └─ Tizen/
```

## Voraussetzungen

- **.NET 9 SDK** (oder passende Preview/RC je nach lokalem Setup)
- Optional:
  - Visual Studio 2022 (mit MAUI-Workload) oder
  - `dotnet` CLI + installierte MAUI Workloads

## Installation

```bash
git clone https://github.com/pKaibel/PocketReader.git
cd PocketReader
dotnet restore PocketReader.sln
```

## Build

```bash
dotnet build PocketReader.sln
```

## Ausführen

### Windows (Beispiel)

```bash
dotnet build PocketReader/PocketReader.csproj -t:Run -f net9.0-windows10.0.19041.0
```

### Android (Beispiel)

```bash
dotnet build PocketReader/PocketReader.csproj -t:Run -f net9.0-android
```

### iOS / MacCatalyst

Für Apple-Ziele benötigst du ein macOS-Setup mit den entsprechenden Workloads/Xcode-Tools.

## Architektur (kurz)

- **Models/** enthält die Domänenobjekte (`Bookmark`)
- **ViewModels/** kapselt Zustände und Logik (`BookmarkViewModel`)
- **Views/** enthält XAML-Seiten (`BookmarkViewPage`)
- **AppShell** definiert die Navigation
- **MauiProgram.cs** registriert Services/Framework-Komponenten

## Abhängigkeiten

Die zentralen NuGet-Pakete sind u. a.:

- `CommunityToolkit.Maui`
- `CommunityToolkit.Mvvm`
- `SQLite-net-pcl`
- `PocketBaseClient`
- `Microsoft.Extensions.Logging.Debug` (Debug-Build)

## Entwicklungsnotizen

- Das Projekt verwendet nullable Referenztypen und implizite usings.
- Für Release-Builds auf Mobile/Desktop gelten die jeweiligen Plattformanforderungen (Signierung, SDKs, Emulators/Devices).

## Nächste sinnvolle Schritte

- README um Screenshots ergänzen
- Konfigurationssektion für Backend/PocketBase konkretisieren
- Tests (Unit/UI) ergänzen
- CI-Build (z. B. GitHub Actions) hinzufügen

## Lizenz

Aktuell ist keine Lizenzdatei im Repository hinterlegt.  
Falls Open Source gewünscht ist, ergänze z. B. eine `LICENSE` (MIT, Apache-2.0, …).

## Autor

- GitHub: [@pKaibel](https://github.com/pKaibel)
- Repository: https://github.com/pKaibel/PocketReader
