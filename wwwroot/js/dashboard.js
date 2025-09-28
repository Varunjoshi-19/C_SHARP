$(document).ready(function() {
  $('#newBlogBtn').click(function() {
    window.location.href = "/Route/CreateBlog"
  });

  $('#searchInput').on('input', function() {
    const val = $(this).val().toLowerCase();
    $('.card').each(function() {
      const text = $(this).text().toLowerCase();
      $(this).toggle(text.indexOf(val) !== -1);
    });
  });



 

});
