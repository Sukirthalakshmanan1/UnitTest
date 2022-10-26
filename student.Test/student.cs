using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest;

namespace student.Test
{
    [TestFixture]
    public class student
    {
        [TestCase]
        public void Validate_student()
        {
            student_unit s = new student_unit();

            s.rollno = 1;
            s.name = "Sukirtha Lakshmanan";
            s.std = 1;

            Assert.AreEqual(s.rollno, 1);
            Console.WriteLine("Student details are successfully validated...");
            Console.WriteLine("Student rollno:"+s.rollno);
            Console.WriteLine("Name:"+s.name);
            Console.WriteLine("Standard :"+s.std);
        }
        [TestCase(11)]

        [TestCase(10)]
        public void Validate_teacher(int id)
        {
            Teacher t=new Teacher();
            t.teacher_id = id;
            t.teacher_name = "sri";
            Assert.AreEqual(t.teacher_id, 11);
            Console.WriteLine("Validation success !!");
            Console.WriteLine("Teacher id:"+t.teacher_id);
            Console.WriteLine("Teacher name:"+t.teacher_name);
        }
        [TestCase(150)]
        public void Validate_subject(int m)
        {
            subject ss = new subject();
            ss.sub_id= 101;
            ss.subject_name = "Maths";
            ss.subject_mark = m;
            Assert.AreEqual(ss.subject_mark, 150);
            Console.WriteLine("subject id:"+ss.sub_id);
            Console.WriteLine("subject name:"+ss.subject_name);
            Console.WriteLine("subject mark"+ss.subject_mark);
            Console.WriteLine("Validation success !!");
        }
    }
}
