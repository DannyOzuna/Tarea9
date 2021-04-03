function msjAlert(title, icon){
    Swal.fire({
        //position: 'top-end',
        icon,
        title,
        showConfirmButton: false,
        timer: 1500
      })
}

function msjConfim(title,text,icon){
    return new Promise (resolve => {
        Swal.fire({
            title,
            text,
            icon,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancelar',
            confirmButtonText: '¡Sí, bórralo!'
          }).then((result) => {
              resolve(result.isConfirmed);
          })
    })
}