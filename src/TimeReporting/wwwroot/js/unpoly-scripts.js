up.log.enable();
up.compiler('.toast', function(element) {
  setTimeout(function() {
    element.remove();
  }, 5000);
});