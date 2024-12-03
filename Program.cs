using uuid;

var list = new List<Guid>() {
    Guid.CreateVersion7(new DateTimeOffset(2024, 12, 1, 12, 34, 56, TimeSpan.Zero)),
    Guid.CreateVersion7(new DateTimeOffset(2024, 12, 2, 12, 34, 56, TimeSpan.Zero)),
    Guid.CreateVersion7(new DateTimeOffset(2024, 12, 3, 12, 34, 56, TimeSpan.Zero)),
    Guid.CreateVersion7(new DateTimeOffset(2024, 12, 4, 12, 34, 56, TimeSpan.Zero)),
    Guid.NewGuid(),
    Guid.CreateVersion7(new DateTimeOffset(2024, 11, 14, 12, 34, 56, TimeSpan.Zero)),
    Guid.NewGuid(),
    Guid.CreateVersion7(new DateTimeOffset(2024, 11, 4, 12, 34, 56, TimeSpan.Zero)),
    Guid.CreateVersion7(new DateTimeOffset(2024, 11, 23, 12, 34, 56, TimeSpan.Zero))
};

Helper.PrintUuidDetails(list, "ORIGINAL");

Helper.PrintUuidDetails(list.OrderBy(x => x), "ASC");

Helper.PrintUuidDetails(list.OrderByDescending(x => x), "DESC");

Console.ReadKey();