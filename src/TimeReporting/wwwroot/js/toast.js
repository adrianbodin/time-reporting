// Ensure a toast container exists
let toastContainer = document.getElementById('toast-container');
if (!toastContainer) {
  toastContainer = document.createElement('div');
  toastContainer.id = 'toast-container';
  toastContainer.className = 'position-fixed top-0 end-0 p-3';
  document.body.appendChild(toastContainer);
}

function createToast(message, type = '') {
  const toastElement = document.createElement('div');
  toastElement.className = 'toast align-items-center border-0';
  toastElement.role = 'alert';
  toastElement.ariaLive = 'assertive';
  toastElement.ariaAtomic = 'true';

  switch (type) {
    case 'success':
      toastElement.classList.add('bg-success', 'text-white');
      break;
    case 'error':
      toastElement.classList.add('bg-error', 'text-white');
      break;
    case 'primary':
      toastElement.classList.add('bg-primary', 'text-white');
  }

  toastElement.innerHTML = `
        <div class="d-flex">
        <div class="toast-body">
            ${message}
        </div>
        <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
        </div>
    `;

  toastContainer.appendChild(toastElement);

  const toast = new bootstrap.Toast(toastElement);

  toastElement.addEventListener('hidden.bs.toast', () => {
    toastElement.remove();
  });

  toast.show();
}

htmx.on("showMessage", (e) => {
  const message = e.detail.message;
  const type = e.detail.type || "";
  createToast(message, type);
});