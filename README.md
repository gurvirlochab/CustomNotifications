# CustomNotifications
C# Custom Dialog box Yes No Option
#Created by Gurvir Lochab

This is a simple DialogBox written in C# for Winform Apps.

To display/call the custom DialogBox use the following code:

    NotificationClasses.DialogFormDisplay nxtfrm = new NotificationClasses.DialogFormDisplay();
    nxtfrm.Display(
        "YesNo", 
        "This is a Title", 
        "This is a dialog box. You can choose to press Yes for more action or No to discard the dialog box\nOption 1\nOption 2\nOption 3"
        );
    nxtfrm.ShowDialog();
