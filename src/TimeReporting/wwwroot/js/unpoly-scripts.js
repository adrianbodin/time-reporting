up.log.enable();
up.compiler('.toast', function(element) {
  setTimeout(function() {
    element.remove();
  }, 5000);
});

up.on('up:location:changed', function() {
  console.log('playwright:continue');
});

up.compiler('#test-chart', function(element, data) {
  const chart = new Chart(element, {
    type: 'bar',
    data: {
      labels: data.Labels,
      datasets: [{
        label: 'Hours',
        data: data.Data,
        borderWidth: 1
      }]
    },
    options: {
      scales: {
        y: {
          beginAtZero: true
        }
      }
    }
  });

  return () => chart.destroy()
});
