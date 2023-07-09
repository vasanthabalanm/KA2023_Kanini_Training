import App from "../App";
import "./ExpenseDateLoad.css"

function ExpenseDateLoad(props){
    const day = props.expdate.toLocaleString("en-US",{day:"2-digit"});
    const month = props.expdate.toLocaleString("en-US",{month:"long"});
    const year = props.expdate.getFullYear();
    return(
        <div>
           <div>{day}</div> 
           <div>{month}</div> 
           <div>{year}</div>
        </div>
    );
}

export default ExpenseDateLoad;