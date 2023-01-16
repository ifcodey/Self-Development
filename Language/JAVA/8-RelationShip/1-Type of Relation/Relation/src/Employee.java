public class Employee {
    private int id;
    private float salary;
    private PersonalInformation personalInf; //instance - composition relationship
    private Department dept; //instance - aggregation relationship

//    public Employee(int id, float salary, PersonalInformation personalInf, Department dept) {
//        this.id = id;
//        this.salary = salary;
//        this.personalInf = personalInf;
//        this.dept = dept;
//    }

//because each life of cycle of them is different we don't use {PersonalInformation personalInf} as param.

    public Employee(int id, float salary, String firstName, String middleName, String lastName, String bloodGroup, String accountNumber, String nationality, int yearOfBirth, Department dept) {
        this.id = id;
        this.salary = salary;
//        because new world --> composition
        this.personalInf = new PersonalInformation(firstName, middleName, lastName, bloodGroup, accountNumber, nationality, yearOfBirth);
//        just pass --> aggregation
        this.dept = dept;
    }

    @Override
    public String toString() {
        return "Employee{" +
                "id=" + id +
                ", salary=" + salary +
                ", personalInf=" + personalInf +
                ", dept=" + dept +
                '}';
    }
}
