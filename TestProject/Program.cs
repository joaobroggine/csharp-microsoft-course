string value1 = " a";
string value2 = "A ";


void Progam(){
    string[] students = ["Sophia", "Andrew", "Emma", "Logan"];
    int[][] grade = [
    new int[] { 90, 86, 87, 98, 100},  // Notas de Sophia
    new int[] { 92, 89, 81, 96, 90 },  // Notas de Andrew
    new int[] { 85, 90, 87, 98, 68 },  // Notas de Emma
    new int[] { 90, 95, 87, 88, 96 }   // Notas de Logan
    ];
    int exam = 100;
    int extra = exam / 10;

    Console.WriteLine($"Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

    for (int i = 0; i < students.Length; i++)
    {
        string names = students[i];
        int[] studentGrades = grade[i];
        decimal sum = 0;

        foreach (var grades in studentGrades)
        {
            sum += grades;
        }

        decimal medias = sum / studentGrades.Length;
        decimal overall = medias;
        string letterGrade = GetLetterGrade(medias);
        decimal[][] extraScore = [
            new decimal[] {3.68m}, // Nota extra de Sophia
            new decimal[] {1.78m}, // Nota extra de Andrew
            new decimal[] {5.34m}, // Nota extra de Emma
            new decimal[] {1.92m}  // Nota extra de Logan
        ];
        decimal[] extraCredit = extraScore[i];


        foreach (var item in extraCredit)
        {
            overall += item;
        }

        for (int itwo = 0; itwo < extraCredit.Length; itwo++)
        {   
            Console.WriteLine($"{names}\t\t{medias:F2}\t\t{overall}\t{letterGrade}\t{medias:F0} ({extraCredit[itwo]} pts)");
            
        }

    }
}

string GetLetterGrade(decimal grade) =>
    grade switch {
        >= 97 => "A+",
        >= 93 => "A",
        >= 90 => "A-",
        >= 87 => "B+",
        >= 83 => "B",
        >= 80 => "B-",
        >= 77 => "C+",
        >= 73 => "C",
        >= 70 => "C-",
        >= 67 => "D+",
        >= 63 => "D",
        >= 60 => "D-",
        _ => "F"
    };

Progam();
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

//     decimal[] english = {4, 3};
//     decimal[] algebra = {3, 3};
//     decimal[] biology = {3, 4};
//     decimal[] computerScience = {3, 4};
//     decimal[] psychology = {4, 3};

//     decimal englishMedia = english[0] * english[1];
//     decimal algebraMedia = algebra[0] * algebra[1];
//     decimal biologyMedia = biology[0] * biology[1];
//     decimal computerScienceMedia = computerScience[0] * computerScience[1];
//     decimal psychologyMedia = psychology[0] * psychology[1];

//     decimal soma = englishMedia + algebraMedia + biologyMedia + 
//     computerScienceMedia + psychologyMedia;
//     decimal horasTotais = english[1] + algebra[1] + biology[1] +
//     computerScience[1] + psychology[1];

//     decimal gpa = soma / horasTotais;

//     Console.WriteLine($"Student: {alunas[0]}");
//     Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
//     Console.WriteLine($"English 101\t\t\t\t{english[0]}\t\t{english[1]}");
//     Console.WriteLine($"Algebra 101\t\t\t\t{algebra[0]}\t\t{algebra[1]}");
//     Console.WriteLine($"Biology 101\t\t\t\t{biology[0]}\t\t{biology[1]}");
//     Console.WriteLine($"Computer Science I\t\t{computerScience[0]}\t\t{computerScience[1]}");
//     Console.WriteLine($"Psychology 101\t\t\t{psychology[0]}\t\t{psychology[1]}");

// }

// Sophia();