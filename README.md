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
01938237-8180-75a2-a3fc-93b5b697e2d8 - 01.12.2024 12:34:56  
0193875d-dd80-78ea-a62f-1b9316fc9db9 - 02.12.2024 12:34:56  
01938c84-3980-7d62-bfb0-9b912bbf671d - 03.12.2024 12:34:56  
019391aa-9580-7311-ba64-e0644c0d4166 - 04.12.2024 12:34:56  
f8af059b-d8dd-4a6b-b03f-bcdc1af65689 - not UUIDv7, no date  
01932aab-6580-7c7d-84aa-fb5ee7ee85c7 - 14.11.2024 12:34:56  
c4e8e777-46bc-49cd-9ad0-f91801ff87f0 - not UUIDv7, no date  
0192f72b-cd80-7752-a18f-fc529af940b4 - 04.11.2024 12:34:56  
01935904-a180-7825-adf5-61d6634fd2b0 - 23.11.2024 12:34:56  

-------------------------ASC  
0192f72b-cd80-7752-a18f-fc529af940b4 - 04.11.2024 12:34:56  
01932aab-6580-7c7d-84aa-fb5ee7ee85c7 - 14.11.2024 12:34:56  
01935904-a180-7825-adf5-61d6634fd2b0 - 23.11.2024 12:34:56  
01938237-8180-75a2-a3fc-93b5b697e2d8 - 01.12.2024 12:34:56  
0193875d-dd80-78ea-a62f-1b9316fc9db9 - 02.12.2024 12:34:56  
01938c84-3980-7d62-bfb0-9b912bbf671d - 03.12.2024 12:34:56  
019391aa-9580-7311-ba64-e0644c0d4166 - 04.12.2024 12:34:56  
c4e8e777-46bc-49cd-9ad0-f91801ff87f0 - not UUIDv7, no date  
f8af059b-d8dd-4a6b-b03f-bcdc1af65689 - not UUIDv7, no date  

-------------------------DESC  
f8af059b-d8dd-4a6b-b03f-bcdc1af65689 - not UUIDv7, no date  
c4e8e777-46bc-49cd-9ad0-f91801ff87f0 - not UUIDv7, no date  
019391aa-9580-7311-ba64-e0644c0d4166 - 04.12.2024 12:34:56  
01938c84-3980-7d62-bfb0-9b912bbf671d - 03.12.2024 12:34:56  
0193875d-dd80-78ea-a62f-1b9316fc9db9 - 02.12.2024 12:34:56  
01938237-8180-75a2-a3fc-93b5b697e2d8 - 01.12.2024 12:34:56  
01935904-a180-7825-adf5-61d6634fd2b0 - 23.11.2024 12:34:56  
01932aab-6580-7c7d-84aa-fb5ee7ee85c7 - 14.11.2024 12:34:56  
0192f72b-cd80-7752-a18f-fc529af940b4 - 04.11.2024 12:34:56  



Dependencies
.NET 9 or higher (for Guid.CreateVersion7() support).
