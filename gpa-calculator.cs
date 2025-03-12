static void Sophia(){
    string aluna = "Sophia Johnson";

    decimal[] english = {4, 3};
    decimal[] algebra = {3, 3};
    decimal[] biology = {3, 4};
    decimal[] computerScience = {3, 4};
    decimal[] psychology = {4, 3};

    decimal englishMedia = english[0] * english[1];
    decimal algebraMedia = algebra[0] * algebra[1];
    decimal biologyMedia = biology[0] * biology[1];
    decimal computerScienceMedia = computerScience[0] * computerScience[1];
    decimal psychologyMedia = psychology[0] * psychology[1];

    decimal soma = englishMedia + algebraMedia + biologyMedia + 
    computerScienceMedia + psychologyMedia;
    decimal horasTotais = english[1] + algebra[1] + biology[1] +
    computerScience[1] + psychology[1];

    decimal gpa = soma / horasTotais;

    Console.WriteLine($"Student: {aluna}");
    Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
    Console.WriteLine($"English 101\t\t\t\t{english[0]}\t\t{english[1]}");
    Console.WriteLine($"Algebra 101\t\t\t\t{algebra[0]}\t\t{algebra[1]}");
    Console.WriteLine($"Biology 101\t\t\t\t{biology[0]}\t\t{biology[1]}");
    Console.WriteLine($"Computer Science I\t\t{computerScience[0]}\t\t{computerScience[1]}");
    Console.WriteLine($"Psychology 101\t\t\t{psychology[0]}\t\t{psychology[1]}");

    Console.WriteLine($"\nFinal GPA:\t\t\t {gpa:F2}");

}

Sophia();