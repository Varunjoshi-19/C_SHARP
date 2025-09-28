$(function() {
  $("#createBlogForm").submit(function(e) {
    e.preventDefault();
    const formData = {
      title: $("#title").val(),
      author: $("#author").val(),
      category: $("#category").val(),
      published: $("#published").is(":checked"),
      content: $("#content").val()
    };
    alert("Blog Created!\n\n" + JSON.stringify(formData, null, 2));
  });

  $(".cancel-btn").click(function() {
    $("#createBlogForm")[0].reset();

    window.location.href = "/Route/Dashboard"
  });

  $("#published").change(function() {
    if ($(this).is(":checked")) {
      $(".draft-label").text("Published");
    } else {
      $(".draft-label").text("Draft");
    }
  });
});
