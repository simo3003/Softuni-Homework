package ClassesAndObjects;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Arrays;
import java.util.Scanner;

public class CountWorkingDays {
    public static void main(String[] args) throws ParseException {
        Scanner scanner = new Scanner(System.in);

        LocalDate[] holidays = new LocalDate[]{
                LocalDate.of(2016, 1, 1),
                LocalDate.of(2016, 3, 3),
                LocalDate.of(2016, 5, 1),
                LocalDate.of(2016, 5, 6),
                LocalDate.of(2016, 5, 24),
                LocalDate.of(2016, 9, 6),
                LocalDate.of(2016, 9, 22),
                LocalDate.of(2016, 11, 1),
                LocalDate.of(2016, 12, 24),
                LocalDate.of(2016, 12, 25),
                LocalDate.of(2016, 12, 26)
        };

        DateTimeFormatter format = DateTimeFormatter.ofPattern("dd-MM-yyyy");

        LocalDate startDate = LocalDate.from(format.parse(scanner.nextLine()));
        LocalDate endDate = LocalDate.from(format.parse(scanner.nextLine()));

        int workingDays = 0;

        for (LocalDate i = startDate; i.isBefore(endDate.plusDays(1)); i = i.plusDays(1)) {
            if(!i.getDayOfWeek().equals(DayOfWeek.SATURDAY)
                    && !i.getDayOfWeek().equals(DayOfWeek.SUNDAY)
                    && !Arrays.asList(holidays).contains(
                       LocalDate.of(2016, i.getMonth(), i.getDayOfMonth()))) {
                workingDays++;
            }
        }

        System.out.println(workingDays);
    }

}
