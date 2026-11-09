# .NET Dojo 🥋

My training hall for backend skills.

Each folder is a small, focused .NET project where I practice **one concept** until I really understand it. Every project runs on its own, has its own README, and explains what I learned in my own words.

![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?logo=dotnet&logoColor=white)

---

## Belt system

Every project earns a belt based on where it is.

| Belt | Meaning |
|---|---|
| ⚪ White belt | Planned. On the training list |
| 🟡 Yellow belt | In training. Being built right now |
| ⚫ Black belt | Mastered. Done, runs, and documented |

---

## Training log

| # | Topic | Project | What I practice | Key concepts | Belt |
|---|---|---|---|---|---|
| 1 | Middleware | [Dojo.Middleware](src/Dojo.Middleware) | Custom middleware for a real API pipeline | Request timing, correlation IDs, global exception handling, API keys | 🟡 Yellow |
| 2 | Caching | [Dojo.Caching](src/Dojo.Caching) | Making slow endpoints fast | In-memory cache, Redis, cache-aside, TTL, invalidation | ⚪ White |
| 3 | System design | [Dojo.UrlShortener](src/Dojo.UrlShortener) | A URL shortener with fast redirects | ID generation, Base62, redirects, caching, rate limiting | ⚪ White |

---

## Dojo rules

How every project in this repo is built:

1. **One concept per project.** Small and focused.
2. **It must run.** One command, no extra setup where possible.
3. **Own words.** Every project README has a "What I learned" section.
4. **Show the trade-offs.** Why I chose one approach over another.

---

## Repo structure

```
dotnet-dojo/
├── src/
│   ├── Dojo.Middleware/
│   │   ├── Middlewares/           the custom middleware classes
│   │   ├── Properties/
│   │   ├── appsettings.json
│   │   ├── Dojo.Middleware.csproj
│   │   ├── Program.cs             wires up the pipeline
│   │   └── README.md              what I built and learned
│   ├── Dojo.Caching/
│   └── Dojo.UrlShortener/
├── .gitignore
├── Directory.Build.props          shared settings for all projects
├── Dojo.slnx                      one solution with every project
└── README.md                      
```

---

## How to run

You need the [.NET SDK](https://dotnet.microsoft.com/download) (8 or newer).

```bash
git clone https://github.com/imaashishlk/dotnet-dojo
cd dotnet-dojo
dotnet run --project src/Dojo.Middleware
```

Swap the project name to run any other project. Each project README explains what to try once it is running.

---

## About me

I'm Aashish, a backend developer in Stavanger, Norway, focused on C# and .NET.

- GitHub: [imaashishlk](https://github.com/imaashishlk)
- LinkedIn: [imaashishkarki](https://linkedin.com/in/imaashishkarki)