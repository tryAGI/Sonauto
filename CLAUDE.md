# CLAUDE.md -- Sonauto SDK

## Overview

Auto-generated C# SDK for [Sonauto](https://sonauto.ai/) (Melodia) -- fast AI song generation
with lyrics. Generates full songs from a natural-language prompt and/or explicit lyrics, with
streaming playback support on v3 (first audio in ~15 seconds).

**No public OpenAPI spec exists** -- `openapi.yaml` was manually compiled from
[sonauto.ai/developers/docs](https://sonauto.ai/developers/docs).

## Build & Test

```bash
dotnet build Sonauto.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (sent via `Authorization: Bearer ...`):

```csharp
var client = new SonautoClient(apiKey); // SONAUTO_API_KEY env var
```

## Key Files

- `openapi.yaml` -- **Manually maintained** OpenAPI spec
- `src/libs/Sonauto/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Sonauto/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Sonauto/Extensions/SonautoClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also drive docs)

## API Base URL

`https://api.sonauto.ai/v1`

Streaming is served from a separate host: `https://api-stream.sonauto.ai/stream/{task_id}` --
not part of this SDK's generated client because it returns raw audio bytes. Call it with any
`HttpClient` and the same Bearer token once you receive a `task_id` from a v3 generation that
was started with `enable_streaming: true`.

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/generations/v3` | POST | Start a Melodia v3 song generation (streaming-capable) |
| `/generations/v2` | POST | Start a Melodia v2 song generation |
| `/generations/v2/extend` | POST | Extend an existing clip (before or after) |
| `/generations/v2/inpaint` | POST | Regenerate sections of an existing clip |
| `/generations/status/{task_id}` | GET | Poll task status (optional alignment status) |
| `/generations/{task_id}` | GET | Fetch completed generation + song URLs |
| `/credits/balance` | GET | Remaining subscription + PAYG credits |

## MEAI Tools

| Tool | Description |
|------|-------------|
| `AsGenerateSongTool()` | Starts a v3 song generation (prompt / lyrics / tags) |
| `AsGetSongStatusTool()` | Polls task status by `task_id` |
| `AsGetSongTool()` | Retrieves completed generation metadata + song URLs |
| `AsGetCreditsTool()` | Returns remaining account credits |

## Notes / Gaps

- There is no public "list genres / moods" endpoint. Tags are free-form strings (the Sonauto
  docs advertise 4,160+ tags curated in their tag explorer, but without a listable REST
  endpoint). The `tags` field on both the request and the `Generation` response is an array of
  arbitrary strings.
- Song download URLs expire ~7 days after generation.
- BPM on v2 can be either the string `"auto"` or an integer -- generated as a `OneOf<int, string>`.
