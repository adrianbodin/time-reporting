document.body.addEventListener('htmx:afterSettle', function(evt) {
  console.log('playwright:continue');
});