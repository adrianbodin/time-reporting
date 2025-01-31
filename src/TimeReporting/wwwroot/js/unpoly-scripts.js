up.log.enable();
up.compiler('.toast', function(element) {
  setTimeout(function() {
    element.remove();
  }, 5000);
});

up.on('up:location:changed', function() {
  console.log('playwright:continue');
});
