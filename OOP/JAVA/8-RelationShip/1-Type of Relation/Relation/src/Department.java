public class Department {
    private int depNo;
    private String deptName;

    public Department() {

    }

    public Department(int depNo, String deptName) {
        this.depNo = depNo;
        this.deptName = deptName;
    }

    // Setter and Getter.
    public int getDepNo() {
        return depNo;
    }

    public void setDepNo(int depNo) {
        this.depNo = depNo;
    }

    public String getDeptName() {
        return deptName;
    }

    public void setDeptName(String deptName) {
        this.deptName = deptName;
    }
}
