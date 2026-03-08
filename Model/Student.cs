namespace ICTPRG547.Model
{
    public class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        private const string DEFAULT_ID = "No student ID provided";
        private const string DEFAULT_FIRSTNAME = "No first name provided";
        private const string DEFAULT_LASTNAME = "No last name provided";

        public Student() : this (DEFAULT_ID, DEFAULT_FIRSTNAME, DEFAULT_LASTNAME)
        {
        
        }

        // Constructor with StudentID only
        public Student(string studentID)
        {
            StudentID = studentID;
            FirstName = DEFAULT_FIRSTNAME;
            LastName = DEFAULT_LASTNAME;
        }

        // Constructor with all properties
        public Student(string studentID, string firstName, string lastName)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return "Student ID: " + StudentID + " First name: " + FirstName + " Last name: " + LastName;
        }

        /// <summary>
        /// override the virtual Equals() method
        /// </summary>
       
        public override bool Equals(object? obj)
        {
            if (obj == null)//check null object to avoid NullReferenceException
                return false;
            if (ReferenceEquals(obj, this))//check reference equality
                return true;
            if (obj.GetType() != this.GetType())//check different object types
                return false;
            Student Student1 = (Student)obj;
            return Student1.StudentID == this.StudentID;
        }

        /// <summary>
        /// Overloads the == operator to compare two Student objects.
        /// </summary>
        public static bool operator ==(Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }

        /// <summary>
        /// Overloads the != operator to compare two Student objects.
        /// </summary>
        public static bool operator !=(Student student1, Student student2)
        {
            return !object.Equals(student1, student2);;
        }

        /// <summary>
        /// Generates a hash code for the Student object using the StudentID.
        /// </summary>
        public override int GetHashCode()
        {
            return StudentID.GetHashCode();
        }
    }
}