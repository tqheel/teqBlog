<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<teqBlog.Models.BlogPost>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>teqBlog</title>
</head>
<body>
    <h1>The teq Blog</h1>
    <div id="posts">
        <% foreach (var p in Model)
           { %>
            
           <h2><%= p.Title %></h2>
           <div id="post<%= p.BlogPostID %>">
                <%= p.Body %>
           </div>
            
            <% } %>
            <%=Html.ActionLink("Create New Post", "Create") %>
    </div>
</body>
</html>
