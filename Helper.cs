namespace uuid;

public  static class Helper {
    public static DateTime ExtractDateFromUuid7(this Guid uuid) {
        byte[] uuidBytes = uuid.ToByteArray();

        // Reorder bytes to match UUID specification (big-endian format)
        byte[] reorderedBytes = new byte[16];

        // Convert first 4 bytes (time_low) to big-endian
        reorderedBytes[0] = uuidBytes[3];
        reorderedBytes[1] = uuidBytes[2];
        reorderedBytes[2] = uuidBytes[1];
        reorderedBytes[3] = uuidBytes[0];

        // Convert next 2 bytes (time_mid) to big-endian
        reorderedBytes[4] = uuidBytes[5];
        reorderedBytes[5] = uuidBytes[4];

        // Convert next 2 bytes (time_hi_and_version) to big-endian
        reorderedBytes[6] = uuidBytes[7];
        reorderedBytes[7] = uuidBytes[6];

        // Copy remaining bytes (clock_seq and node) as-is
        Array.Copy(uuidBytes, 8, reorderedBytes, 8, 8);

        // Validate that the UUID is version 7
        int version = (reorderedBytes[6] & 0xF0) >> 4;
        if (version != 7) {
            return DateTime.MinValue;
        }

        // Extract the first 6 bytes (48 bits) of the UUID (timestamp)
        long timestampMs = ((long)reorderedBytes[0] << 40)
                         | ((long)reorderedBytes[1] << 32)
                         | ((long)reorderedBytes[2] << 24)
                         | ((long)reorderedBytes[3] << 16)
                         | ((long)reorderedBytes[4] << 8)
                         | reorderedBytes[5];

        // Convert the timestamp from milliseconds since Unix epoch to DateTime
        return DateTimeOffset.FromUnixTimeMilliseconds(timestampMs).UtcDateTime;
    }

    public static void PrintUuidDetails(IEnumerable<Guid> uuids, string header) {
        Console.WriteLine(new string('-', 25) + header);
        foreach (var uuid in uuids) {
            var date = uuid.ExtractDateFromUuid7();
            if (date == DateTime.MinValue)
                Console.WriteLine($"{uuid} - not UUIDv7, no date");
            else
                Console.WriteLine($"{uuid} - {date}");
        }
    }
}