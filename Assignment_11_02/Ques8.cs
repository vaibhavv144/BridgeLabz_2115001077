using System;

class TextState
{
    public string Content;
    public TextState Prev;
    public TextState Next;

    public TextState(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextState currentState;
    private int historySize = 10;
    private int stateCount = 0;

    public void AddTextState(string newText)
    {
        TextState newState = new TextState(newText);
        
        if (currentState != null)
        {
            newState.Prev = currentState;
            currentState.Next = newState;
        }
        
        currentState = newState;
        stateCount++;

        // Remove oldest history if limit exceeded
        if (stateCount > historySize)
        {
            TextState temp = currentState;
            while (temp.Prev != null)
                temp = temp.Prev;

            temp.Next.Prev = null;
            stateCount--;
        }
    }

    public void Undo()
    {
        if (currentState != null && currentState.Prev != null)
        {
            currentState = currentState.Prev;
            Console.WriteLine("Undo: " + currentState.Content);
        }
        else
        {
            Console.WriteLine("Nothing to undo.");
        }
    }

    public void Redo()
    {
        if (currentState != null && currentState.Next != null)
        {
            currentState = currentState.Next;
            Console.WriteLine("Redo: " + currentState.Content);
        }
        else
        {
            Console.WriteLine("Nothing to redo.");
        }
    }

    public void DisplayCurrentState()
    {
        if (currentState != null)
            Console.WriteLine("Current State: " + currentState.Content);
        else
            Console.WriteLine("No text available.");
    }
}

class Ques8
{
    public static void Print()
    {
        TextEditor editor = new TextEditor();

        editor.AddTextState("Hello");
        editor.AddTextState("Hello, World!");
        editor.AddTextState("Hello, World! This is a test.");
        editor.DisplayCurrentState();

        editor.Undo();
        editor.Undo();
        editor.Redo();
        editor.DisplayCurrentState();
    }
}
