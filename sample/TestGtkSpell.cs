using System;
using Gtk;
using GtkSpell;

public class GtkHelloWorld {
 
  public static void Main() {
    Application.Init();

    //Create the Window
    Window myWin = new Window("GtkSpell# Sample App");
    myWin.Resize(200,200);
    
    //Create a TextView 
    TextView myTextView = new TextView();
    
    //Bind GtkSpell to our textview
    SpellCheck mySpellCheck = new SpellCheck(myTextView, "en-us");

    //spellCheck.Detach();
    //spellCheck.();

    //Add the TextView to the form     
    myWin.Add(myTextView);
    
    //Show Everything     
    myWin.ShowAll();
    
    Application.Run();   
   }
}
