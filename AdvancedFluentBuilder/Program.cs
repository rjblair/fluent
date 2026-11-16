// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using AdvancedFluentBuilder.Dtos;
using AdvancedFluentBuilder.Implementations;

Console.WriteLine("Hello, World!");

var memberBuilder = new MemberBuilder();

var ahmed =
    memberBuilder
        .New
        .WithName("Ahmed")
        .WithAge(36)
        .AsTeacher
        .Teaching(new Subject("Software Engineering"))
        .WithSchedule(
            new Schedule
            (
                new DateTime(2021, 11, 20),
                new DateTime(2021, 12, 20)
            ), new Schedule
            (
                new DateTime(2022, 1, 5),
                new DateTime(2021, 3, 5)
            ))
        .Build();

ahmed.Dump();

var subjectsToStudy = new Subject[]
{
                new Subject("Software Engineering"),
                new Subject("Physics")
};

var mohamed =
    memberBuilder
        .New
        .WithAge(15)
        .WithName("Mohamed")
        
        .AsStudent
        .Studying(subjectsToStudy)
        .WithSchedule
        (
            new SubjectSchedule
            (
                subjectsToStudy[0],
                new Schedule
                (
                    new DateTime(2021, 11, 20),
                    new DateTime(2021, 12, 20)
                )
            ),
            new SubjectSchedule
            (
                subjectsToStudy[1],
                new Schedule
                (
                    new DateTime(2021, 11, 20),
                    new DateTime(2021, 12, 20)
                )
            )
        )
        .Build();

mohamed.Dump();

public static class DumpExtension
{
    public static string Dump(this object value)
    {
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        var output = JsonSerializer.Serialize(value, options);
        Console.WriteLine(output);
        return output;
    }
}