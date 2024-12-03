# UUID Sorting Test

This repository provides a simple test to demonstrate the sorting of **UUIDs**, with a specific focus on **UUID v7** (time-ordered UUIDs). It includes functionality to extract and display the timestamp encoded in UUID v7 and sort a list of UUIDs in both ascending and descending order.

---

## Features
- Generate a mix of UUID v7 and random UUIDs.
- Extract timestamps from UUID v7 values.
- Sort UUIDs:
  - Original order
  - Ascending order
  - Descending order.
- Display results with timestamps or indicate if the UUID is not v7.

-------------------------ORIGINAL
018d1e7e-5a6e-7a93-8000-4f3556a7d65c - 2024-12-01T12:34:56.000Z
c66e5e97-0e0d-4f9e-80ec-10b29f52e5a2 - not UUIDv7, no date
-------------------------ASC
018d1e7e-5a6e-7a93-8000-4f3556a7d65c - 2024-12-01T12:34:56.000Z
c66e5e97-0e0d-4f9e-80ec-10b29f52e5a2 - not UUIDv7, no date
-------------------------DESC
c66e5e97-0e0d-4f9e-80ec-10b29f52e5a2 - not UUIDv7, no date
018d1e7e-5a6e-7a93-8000-4f3556a7d65c - 2024-12-01T12:34:56.000Z


Dependencies
.NET 9 or higher (for Guid.CreateVersion7() support).