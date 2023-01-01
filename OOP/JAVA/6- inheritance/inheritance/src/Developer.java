public class Developer extends Employee {
    protected String projectName;

    public Developer() {
        System.out.println("Sub - Class");
    }

    public Developer(String name, String emailAddress, String phone, String department, String address, int yearsOfBirth , String projectName) {
//        super is a inheritance from Employee constructor.
        super(name,emailAddress,phone,department,address,yearsOfBirth);
        this.projectName = projectName;
    }

    public String getProjectName() {
        return projectName;
    }

    public void setProjectName(String projectName) {
        this.projectName = projectName;
    }
}
