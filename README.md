# Apartment Finder — Dual-Stack Implementation

A full-stack Apartment Finder application built in **C# / ASP.NET** — to demonstrate the SOC system design.

---

## Architecture

```
SOC_PROJECT/
├── HomeAndUserClient/        # Frontend — JavaScript + CSS web client
├── HomeAndUserLibrary/       # Shared library — models, interfaces, business logic
└── UserServiceHostConsole/   # Service host — C# console app exposing user services
```

| Layer | Tech | Responsibility |
|---|---|---|
| Client | JavaScript, CSS | UI and user interactions |
| Library | C# | Shared models, DTOs, service interfaces |
| Service Host | C#, ASP.NET | Hosts and exposes user/home services |

---

## Tech Stack
| Layer | Technology |
|---|---|
| Backend | C#, ASP.NET |
| Architecture | Service-Oriented Architecture (SOA) |
| Frontend | JavaScript, CSS |
| Service Host | Console-based Windows/Linux service |

---

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or later)
- Node.js (for the client, if applicable)

### Run the Service Host

```bash
cd UserServiceHostConsole
dotnet restore
dotnet run
```

### Run the Client

```bash
cd HomeAndUserClient
# Open index.html in a browser, or serve with a local server:
npx serve .
```

---
