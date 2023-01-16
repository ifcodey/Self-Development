public class Main {
    public static void main(String[] args) {
//        PersonalInformation person = new PersonalInformation();
        ْDepartment dept = new Department(123, "IT");
        Employee emp = new Employee(1, 25000, "Ali", "Ahmed", "Belal", "o+", "536548", "palestinain", 1999, dept);
        Employee emp2 = new Employee(2, 20000, "Omar", "Wahdan", "jaber", "o+", "536548", "palestinain", 1999, dept);

        System.out.println(dept.toString());
    }
}