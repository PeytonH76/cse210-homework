using System;

public class MathAssignment: Assignment{

    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbookSection, string problems, string studentname, string topic) : base(studentname, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return $"Section {_textbookSection} Problems {_problems}";
    }
}