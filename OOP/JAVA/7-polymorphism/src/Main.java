
public class Main {
    public static void main(String[] args) {

        Employee e1 = new Employee("Ahmed", "Amman", "0256583356", "", "", 1000);
        SalariedEmployee Se1 = new SalariedEmployee("Ahmed", "Amman", "0256583356", "", "", 1000, 200);

        DaliyEmployee De1 = new DaliyEmployee("Ahmed", "Amman", "0256583356", "", "", 0, 152, 1);
        HourlyEmployee He1 = new HourlyEmployee("Ahmed", "Amman", "0256583356", "", "", 0, 19, 8);

        System.out.printf("\nEmployee basic : %s\n", e1.getSalary());
        System.out.printf("SalariedEmployee : %s\n", Se1.getSalary());

        System.out.printf("DailyEmployee : %s\n", De1.getSalary(-50));
        System.out.printf("HourlyEmployee : %s\n", He1.getSalary(-50));


        //    ----------------- [ Other way to convert e1 from employee to salaryEmployee by concept polymorphism -> override ]------------------

        e1 = new SalariedEmployee("Ahmed", "Amman", "0256583356", "", "", 1000, 200);
        System.out.printf("\nSalariedEmployee : %s\n", Se1.getSalary());

        //    ----------------- [ Static can't used concept override ]------------------

//        subclass -> there is overriding.
        e1.printWithoutStatic();

//        baseclass -> no overriding.
        e1.printWithStatic();
    }
}