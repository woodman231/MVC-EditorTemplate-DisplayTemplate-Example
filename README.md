# MVC EditorTemplate DisplayTemplate Example

This MVC App is to demonstrate the use of DisplayTemplate and EditorTemplates.

DisplayTemplates and EditorTemplates are particularly useful when a project should share View code across multiple Views.

DisplayTemplates are particularly useful for sharing code on the Details and Delete Views.

EditorTemplates are particularly useful for sharing code on the Create and Edit Views.

The trick is to create a "DisplayTemplate" and "EditorTemplate" folder underneath the Views -> Shared folder within the project.

Once the folders are in place, Empty Views (cshtml) will need to be created with the name of the Model that will be passed in.

![Key Folder Structure](https://github.com/woodman231/MVC-EditorTemplate-DisplayTemplate-Example/blob/main/MVC-EditorTemplate-DisplayTemplate-Example/wwwroot/KeyFolderStructure.PNG)

Each View should have the @model NameSpace.Models.ModelName that is being targetting for that view at the top, and then the rest of the code after that.

Once the code is ready the @Html.DisplayForModel() or @Html.EditorForModel() can be placed in places within other views of a similar model would be displayed.

Now any changes made to the DisplayTemplate or EditorTemplate will be filled in on the views which were the @Html.DisplayForModel() or @Html.EditorForModel() were placed.

In this example the Person DisplayTemplate is used on the Details and Delete Person Views. The Person EditorTemplate is used on the Create and Edit Person Views.
