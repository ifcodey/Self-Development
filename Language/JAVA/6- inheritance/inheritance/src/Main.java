
public class Main {
    public static void main(String[] args) {
        Developer o1 = new Developer();
//        private variable.
        o1.setName("Ali");
//        protected variable.
        o1.projectName = "Task One";
        System.out.println(o1.projectName);

        Developer o2 = new Developer("Ahmed", "ifco@gmail.com", "02358652", "Rolanes", "near to red station gas", 2000, "Project navbar task");
        System.out.printf("\nThe name is = %s \nThe email is = %s \nThe phone is = %s \nThe department is = %s \nThe projectName is = %s\n" , o2.getName() , o2.getEmailAddress() , o2.getPhone(),o2.getPhone(),o2.getDepartment(),o2.getProjectName() );
    }
}