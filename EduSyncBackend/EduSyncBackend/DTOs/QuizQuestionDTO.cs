﻿public class QuizQuestionDTO
{
    public Guid QuestionId { get; set; }
    public string QuestionText { get; set; }
    public List<string> Options { get; set; }
    public string CorrectAnswer { get; set; }
    public string SelectedOption { get; set; }  // Optional for result view
}
