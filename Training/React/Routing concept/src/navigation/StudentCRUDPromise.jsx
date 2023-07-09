import React, { useEffect, useState } from 'react'

const StudentCRUDPromise =() => {
    const [students, setstudents] = useState([]);
    // const [newstudent, setnewstudent] = useState(
    //     {
    //         stuID: '',
    //         studName: '',
    //         city: '',
    //         pin: ''
    //     }
    // );
    const fetchstudents = () =>{
        fetch('your uel get')
        .then((response) => response.json())
        .then((data)=>setstudents(data))
        .catch((error)=>console.error(error));
    }
  return (
    <div>StudentCRUDPromise</div>
  )
};

export default StudentCRUDPromise