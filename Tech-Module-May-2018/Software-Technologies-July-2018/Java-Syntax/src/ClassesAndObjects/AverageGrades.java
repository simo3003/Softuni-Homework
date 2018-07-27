package ClassesAndObjects;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.Arrays;
import java.util.stream.Collectors;

public class AverageGrades {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int studentsCount = Integer.parseInt(scanner.nextLine());
        List<Student> students = new ArrayList<>();

        for (int index = 0; index < studentsCount; index++) {

            String[] studentsTokens = scanner.nextLine().split(" ");

            String name = studentsTokens[0];

            List<Double> grades = Arrays.stream(studentsTokens)
                    .skip(1)
                    .map(Double::parseDouble)
                    .collect(Collectors.toList());

            Student student = new Student(name, grades);

            students.add(student);
        }

        students.stream()
                .filter(s -> s.getAvgGrade() >= 5.00)
                .sorted((a, b) -> {
                    int comparisonResult = a.getName().compareTo(b.getName());

                    if (comparisonResult == 0) {

                        comparisonResult = Double.compare(
                                b.getAvgGrade(), a.getAvgGrade());
                    }

                    return comparisonResult;
                })
                .forEach(s -> System.out.printf(
                        "%s -> %.2f%n", s.getName(), s.getAvgGrade()));
    }
}

class Student {

    private String name;
    private List<Double> grades;

    Student(String name, List<Double> grades) {

        this.name = name;
        this.grades = grades;
    }

    String getName() {
        return name;
    }

    Double getAvgGrade() {

        double averageGrade = this.grades
                .stream()
                .mapToDouble(grades -> grades)
                .average()
                .getAsDouble();
        return averageGrade;
    }
}
