# The Bureaucracy at the End of the Universe

A showcase story for [@EpicronBot](t.me/EpicronBot), written in [YarnSpinner](https://yarnspinner.dev/).

## Story

You've crash-landed at Outpost Omega-9, the last functioning government office in the known universe. All you need is a simple transit permit. It should take five minutes. It has been three weeks.

A Pratchett-style comedy sci-fi with full character creation, branching paths, dice rolls, and multiple endings.

## Features Showcased

- **Character creation**: species (5 options), gender, class (5 options) — all affect stats and story branches
- **Stats**: Charm, Wit, Brawn, Luck — gating dialogue options and dice outcomes
- **Resources**: Credits, Patience, Stamps — managed across the story
- **`send_picture`** and **`send_audio`** commands
- **`get_player_name()`** function (appears on the notice board)
- **`dice()`** and **`random_range()`** for randomised outcomes
- **`visited()`** / **`visited_count()`** compatible node structure
- **Auto-roll**: the "Talk to travelers" hub has 6 options, triggering a random encounter
- **`<<wait>>`** command for dramatic pauses
- **Multiple endings**: Legitimate escape, unauthorised escape, exhaustion/permanent residency
- **High replayability**: different species/class combos unlock different dialogue, dice rolls vary each run, stat-gated options change available paths

## Compiling

From the `source/` directory:

```bash
mkdir ../compiled
ysc compile --output-directory ../compiled/ --output-name story $(ls | grep ".yarn")
```

## Pictures needed

Place these in `pictures/`. All images share the same art direction — see the **Art Style** section below before generating.

---

### Art Style Reference

All images must be consistent with this base style prompt. Prepend it to every individual prompt below:

> **Base style:** `retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover, Terry Pratchett Discworld energy, absurdist bureaucratic humour, no photorealism, no gradients`

---

### `bureau_logo.png` — Station logo / title card

> An official-looking emblem for "OUTPOST OMEGA-9 — Universal Transit Authority". A circular badge with a ringed planet at the centre, surrounded by a ring of tiny rubber stamps, a laurel wreath made of paperclips, and the motto "YOUR PATIENCE IS OUR POLICY" in small block letters at the bottom. Institutional, pompous, slightly falling apart. Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `docking_bay.png` — Docking bay exterior

> Interior of a cramped, dimly lit space station docking bay. A battered escape pod has just crash-landed, smoke rising from its hull, one panel hanging off. The bay walls are covered in peeling safety notices, yellow hazard stripes, and a large sign reading "WELCOME TO OMEGA-9 — PLEASE HAVE YOUR DOCUMENTS READY". Flickering fluorescent tubes overhead. One bored alien maintenance worker leans on a mop in the background, ignoring the emergency. Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `main_hall.png` — The main waiting hall

> A vast, cathedral-ceilinged waiting hall inside a space station, packed with hundreds of miserable alien travellers sitting on rows of hard plastic chairs bolted to the floor. Enormous queue number displays on the walls show numbers in the thousands. Motivational posters line the walls: "FORM 27B/6 IS YOUR FRIEND", "QUEUING IS CARING", "HAVE YOU TRIED THE VENDING MACHINE?". Dust motes float in shafts of sickly fluorescent light. The ceiling is so high it disappears into haze. Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `window1.png` — The clerk's window

> A bureaucratic service window with thick scratched plexiglass. Behind it sits a bored, middle-aged alien clerk with three eyes, wearing a beige uniform with too many pens in the breast pocket. A small sign reads "WINDOW 1 — ALL ENQUIRIES". The desk behind the glass is buried under towering stacks of paper forms, rubber stamps, and a coffee mug that says "I'D RATHER BE FILING". A small "NEXT" button glows red on the counter. Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `waiting_area.png` — Rows of waiting travellers

> A wide shot of the waiting area: rows of hard plastic chairs occupied by a diverse crowd of alien species — tall, short, gaseous, crystalline, tentacled — all looking equally defeated. Some are asleep. One is knitting. A small robot rolls between the rows selling lukewarm beverages from a tray. A digital display on the wall reads "NOW SERVING: 0047. YOUR NUMBER: 3,891." Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `glorb.png` — The knitting Glorbian

> Portrait of a Glorbian alien: seven feet tall, three arms, pale green skin, small kind eyes, wearing a hand-knitted cardigan covered in star patterns. Two of their three arms are actively knitting an enormous, colourful scarf that pools on the floor around their feet. They sit in a waiting-room chair that is visibly too small for them, looking perfectly content. A small pile of finished knitted items sits beside them. Warm, gentle, slightly absurd. Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `vending_machine.png` — The vending machine

> A battered, ancient vending machine in a space station corridor. The machine is enormous, covered in dents and stickers, with a cracked display screen showing "OUT OF ORDER" and "PLEASE EXACT CHANGE ONLY" simultaneously. The selection window shows a single sad sandwich behind smudged glass, labelled "MEAL-7B (CONTENTS UNKNOWN)". A handwritten note taped to the side reads "DO NOT KICK — MAINTENANCE NOTIFIED 3 YEARS AGO". Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `notice_board.png` — The notice board

> A large corkboard on a space station wall, absolutely covered in overlapping notices, memos, and flyers pinned at every angle. Notices include: "LOST: ONE TRANSIT PERMIT (REWARD: ANOTHER TRANSIT PERMIT)", "ROOM FOR RENT — LONG-TERM RESIDENTS ONLY", "FORM 27B/6 NOW AVAILABLE AT WINDOW 1 (LIMIT: ONE PER DECADE)", and a hand-drawn map of the station with most of it crossed out and labelled "CLOSED". Some notices are so old they are yellowing and curling at the edges. Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `camper.png` — The long-term resident's camp

> A cosy, improvised living camp set up in a corner of a space station waiting hall. A weathered traveller has made themselves at home: a cot with a patchwork blanket, a small camp stove, shelves made from stacked form-boxes, string lights, potted alien plants, framed photos on the wall, and a hand-painted sign reading "HOME SWEET OMEGA-9". The surrounding station is grey and institutional, making the little camp feel warm and absurd by contrast. Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `directors_office.png` — The Director's office

> A grand, self-important office inside a space station. Behind an enormous mahogany-style desk sits a small, pompous alien Director in a uniform covered in medals and badges, most of which appear to be self-awarded. The desk is suspiciously clear of paperwork. The walls are covered in framed certificates, portraits of the Director shaking hands with various dignitaries, and a large window showing the stars outside. A name plate reads "DIRECTOR VOSS — SUPREME ADMINISTRATOR, OMEGA-9". Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `departure_gate.png` — The departure gate

> A space station departure gate: a wide archway leading to a boarding tunnel, with a large illuminated sign reading "GATE OMEGA — DEPARTURES". The gate is staffed by a single bored guard checking documents with a handheld scanner. A small crowd of travellers waits with luggage, looking cautiously hopeful. Through a porthole window beside the gate, a starfield and a docked ship are visible. The floor has a worn yellow line that says "AUTHORISED TRAVELLERS ONLY BEYOND THIS POINT". Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

### `space_escape.png` — Open space, freedom

> A wide, cinematic view of open space from just outside a space station airlock. The station's hull is visible at the edge of the frame, receding. In the centre, a small figure in a spacesuit (or a tiny ship) floats free against an enormous, beautiful starfield — a nebula in amber and teal fills the background. The feeling is exhilarating and slightly absurd: freedom achieved through sheer bureaucratic exhaustion. Retro sci-fi comic book illustration, flat cel-shading, bold ink outlines, limited warm colour palette (amber, teal, off-white, deep navy), slightly worn and faded like a 1970s paperback cover.

---

## Audios needed

Place these in `audios/`:
- `arrival_klaxon.wav` — station arrival alarm/fanfare
- `departure_fanfare.wav` — triumphant departure music
