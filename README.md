# Timothy's Terminal

[![Deployed with GitHub Pages](https://github.com/timotheus1907/timotheus1907.github.io/actions/workflows/deploy.yml)

My personal developer portfolio, styled like a terminal.

**Live site:** <https://timotheus1907.github.io/>

## Features

- Dark, terminal-inspired design using only Bootstrap's own colours
- Edge-to-edge Projects page with a navbar dropdown
- Fully static: no backend, everything runs in the browser

## Tech stack

| | |
|---|---|
| Framework | C#, .NET 10, Blazor WebAssembly (Standalone) |
| Styling | Bootstrap 5.3 (CSS only) |
| Hosting | GitHub Pages, deployed with GitHub Actions |

## Run locally

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
git clone https://github.com/timotheus1907/timotheus1907.github.io.git
cd timotheus1907.github.io
dotnet run
```

## Project structure

```
.github/workflows/deploy.yml   Build and deploy on every push to main
Data/ProjectData.cs            The project list (used by the Projects page and the navbar)
Layout/NavMenu.razor           Top navigation bar and Projects dropdown
Pages/Projects.razor           Edge-to-edge project list
wwwroot/images/                Screenshots and icons
wwwroot/css/app.css            Custom styles
```

## Adding a project

1. Save an image in `wwwroot/images/` (about 1920px wide, 21:9).
2. Add one line to `Data/ProjectData.cs`. `Href` is the source code (or live site) link, and `IsWip: true` fades the project and disables its link.
3. Push to `main`. The Projects page and the navbar dropdown both update automatically.

## Deployment

Pushing to `main` builds and deploys the site with GitHub Actions, using [PublishSPAforGitHubPages.Build](https://www.nuget.org/packages/PublishSPAforGitHubPages.Build) for GitHub Pages support.

## Other projects
 
- Links to **Companydle**, a daily guess-the-company game: <https://timotheus1907.github.io/companydle/>