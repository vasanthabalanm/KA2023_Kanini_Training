import React, { useEffect, useState } from 'react'
import axios from 'axios'
const StudentCRUD = () => {
    const [students, setstudents] = useState([]);
    const basepath = "https://localhost:7255";

    const newstudents = {
        stuID: 5,
        studName: "naruto",
        city: "hiddenleaf",
        pin: 3928
    };
    const updatestudent = {
        studName: "Choji",
        city: "Leaf",
        pin: 987
    };

    useEffect(() => {
        fetchstudents();
    },
        [students]
    );


    const fetchstudents = async () => {
        try {
            const response = await axios.get(basepath + `/api/Student`);
            setstudents(response.data);
        }
        catch (error) {
            console.error(error);
        }
    }

    const createstudents = async () => {
        try {
            const response = await axios.post(basepath + "/api/Student", newstudents);
            setstudents([...students, response.data]);
        }
        catch (error) {
            console.error(error);
        }
    }

    const updatestudents = async(id)=>{
        try {
            console.log(id);
            const response = await axios.put(basepath + `/api/Student/${id}`,updatestudent);
            // fetchstudents();
            const upstu = students.map((stud)=>{
                if(stud.stuID === id){
                   return response.data;
                }
                return students;
            });
            setstudents(upstu);
        }
        catch (error) {
            console.error(error);
        }
    }
    const deletestudents = async(id)=>{
        try {
            // const response = await axios.get(basepath + `/api/Student/${id}`);
            // setstudents(response.data);
            // const updatestude = students.filter((students)=>student.stuID != id)
            // setstudents(updatestudent);
            await axios.delete(basepath + `/api/Student/${id}`);
            fetchstudents();
        }
        catch (error) {
            console.error(error);
        }
    }
    return (
        <div>
            <h1>Student CRUD operation</h1>
            <button onClick={createstudents}>create students</button>
            <ul>
                {students.map((student) => (
                    <li key={student.stuID}>
                        <span> STUDENT ID: &nbsp;&nbsp; {student.stuID}</span><br></br>
                        <span>STUDENT NAME:&nbsp;&nbsp;{student.studName}</span><br></br>
                        <span>STUDENT CITY:&nbsp;&nbsp;{student.city}</span><br></br>
                        <span>STUDENT PIN:&nbsp;&nbsp;{student.pin}</span>
                        <button onClick={() =>updatestudents(student.stuID)}>Update</button>
                        <button onClick={() =>deletestudents(student.stuID)}>Delete</button>



                    </li>

                ))}
            </ul>
        </div>
    )
}

export default StudentCRUD