<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<teqBlogModel.BlogPost>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>teqBlog</title>
    <link href="~/Styles/main.css" rel="stylesheet" type="text/css" media="screen" />
</head>
<body>
    <h1>teqBlog</h1>
    <div id="posts">
        <% foreach (var p in Model)
           { %>
            
           <div class="post-title"><%= p.Title %></div>
           <div class="create-timestamp whitespace">Post Created: <%=p.DateCreated %></div>
           <div class="post-body" id="post<%= p.BlogPostID %>">
                <%= p.Body %>
           </div>
            
            <% } %>
            <%=Html.ActionLink("Create New Post", "Create") %>
    </div>
</body>
</html>
