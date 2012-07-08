<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<teqBlog.Models.BlogPost>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Create New Post</title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Title) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Title) %>
                <%: Html.ValidationMessageFor(model => model.Title) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Body) %>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.Body) %>
                <%: Html.ValidationMessageFor(model => model.Body) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>
        
    <% } %>

    <div>
        <%: Html.ActionLink("Home", "Index") %>
    </div>

</body>
</html>

