 $(document).ready(function () {
    $(".dropdown-btn").click(function () {
      $(this).parent(".category-dropdown").toggleClass("open");
    });
  });