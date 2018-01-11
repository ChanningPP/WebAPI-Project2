using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Controllers
{
    public class SchoolDataStore
    {
        private static SchoolDataStore _instance;

        public static SchoolDataStore Instance()
        {
            if (_instance == null)
            {
                _instance = new SchoolDataStore();
            }
            return _instance;
        }

        private List<CourseDTo> _Courses;
        private List<LecturerDTo> _Lecturers;
        private List<StudentDTo> _Students;
        private static List<CourseDTo> CourseSeed()
        {
            List<CourseDTo> CourseSeed = new List<CourseDTo>();
            CourseSeed.Add(new CourseDTo
            {
                Id = 1,
                Name = "Math",
                MaxNum = 100,
                Credit = 2

            });
            return CourseSeed;

        }

        private static List<LecturerDTo> LecturerSeed()
        {
            List<LecturerDTo> LecturerSeed = new List<LecturerDTo>();
            LecturerSeed.Add(new LecturerDTo
            {
                Id = 1,
                Name = "Jack",
                Payroll = 1000,
                Message = "it is too hard"
            });
            return LecturerSeed;

        }

        private static List<StudentDTo> StudentSeed()
        {
            List<StudentDTo> StudentSeed = new List<StudentDTo>();
            StudentSeed.Add(new StudentDTo
            {
                Id = 1,
                Name = "harry",
                StudentFee = 2000,
                Credit = 16

            });
            return StudentSeed;

        }

        public SchoolDataStore()
        {
            _Courses = CourseSeed();
            _Lecturers = LecturerSeed();
            _Students = StudentSeed();

        }


        public List<CourseDTo> GetAllCourses()
        {
            return _Courses;
        }

        public List<LecturerDTo> GetAllLecturers()
        {
            return _Lecturers;
        }

        public List<StudentDTo> GetAllStudents()
        {
            return _Students;
        }

        public CourseDTo GetCourseById(int Id)
        {
            CourseDTo result = _Courses.FirstOrDefault((CourseDTo arg) => arg.Id == Id);
            return result;
        }

        public LecturerDTo GetLecturerById(int Id)
        {
            LecturerDTo result = _Lecturers.FirstOrDefault((LecturerDTo arg) => arg.Id == Id);
            return result;
        }

        public StudentDTo GetStudentById(int Id)
        {
            StudentDTo result = _Students.FirstOrDefault((StudentDTo arg) => arg.Id == Id);
            return result;
        }

        public void AddCourse(CourseDTo newCourse)
        {
            _Courses.Add(newCourse);
        }

        public void AddLecturer(LecturerDTo newLecturer)
        {
            _Lecturers.Add(newLecturer);
        }

        public void AddStudent(StudentDTo newStudent)
        {
            _Students.Add(newStudent);
        }

        public CourseDTo UpdateCourse(CourseDTo newCourse)
        {
            CourseDTo result = _Courses.FirstOrDefault((CourseDTo arg) => arg.Id == newCourse.Id);
            if(result != null)
            {
                result.Name = newCourse.Name;
                result.Credit = newCourse.Credit;
                result.MaxNum = newCourse.MaxNum;

            }
            return result;
        }

        public LecturerDTo UpdateLecturer(LecturerDTo newLecturer)
        {
            LecturerDTo result = _Lecturers.FirstOrDefault((LecturerDTo arg) => arg.Id == newLecturer.Id);
            if (result != null)
            {
                result.Name = newLecturer.Name;
                result.Payroll = newLecturer.Payroll;
                result.Message = newLecturer.Message;      
            }
            return result;

        }

        public StudentDTo UpdateStudent(StudentDTo newStudent)
        {
            StudentDTo result = _Students.FirstOrDefault((StudentDTo arg) => arg.Id == newStudent.Id);
            if (result != null)
            {
                result.Name = newStudent.Name;
                result.StudentFee = newStudent.StudentFee;
                result.Credit = newStudent.Credit;
            }
            return result;

        }

        public bool DeleteCourse(int Id)
        {
            bool result = false;
            CourseDTo obj = _Courses.FirstOrDefault((CourseDTo arg) => arg.Id == Id);
            if(obj != null)
            {
                _Courses.Remove(obj);
                result = true;
            }
            return result;
        }

        public bool DeleteLecturer(int Id)
        {
            bool result = false;
            LecturerDTo obj = _Lecturers.FirstOrDefault((LecturerDTo arg) => arg.Id == Id);
            if(obj != null)
            {
                _Lecturers.Remove(obj);
                result = true;
            }
            return result;
        }

        public bool DeleteStudent(int Id)
        {
            bool result = false;
            StudentDTo obj = _Students.FirstOrDefault((StudentDTo arg) => arg.Id == Id);
            if (obj != null)
            {
                _Students.Remove(obj);
                result = true;
            }
            return result;
        }


    }
}
