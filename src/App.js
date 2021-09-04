import React from 'react';
import './App.css';
class Contact extends React.Component{
    state = {
        contactData : [{}]
    }
   async getContactusers (){
       const response = await fetch('https://60ac9dff9e2d6b0017457815.mockapi.io/ag/contacts');
       const data = await response.json();
       console.log(data); 
    this.setState({contactData: data})
    }
    componentDidMount() {
        this.getContactusers()
      }
    
    render(){
        return(
            <>
            <h4>Contact_data</h4>
                 <div>
                     
                     <table>
                         <thead>
                                 <th>id</th>
                                 <th>avatar</th>
                                 <th>first_name</th>
                                 <th>last_name</th>
                                 <th>phone</th>
                                 <th>email</th>
                                 <th>company</th>
                                 <th>job_title</th>
                         </thead>
                         <tbody>
                         {
                            this.state.contactData.map((user)=>(
                            <tr>
                                <td>{user.id}</td>
                                <td> <img src={user.avatar} alt="avatar" width="40px"/></td>
                                <td>{user.first_name}</td>
                                <td>{user.last_name}</td>
                                <td>{user.phone}</td>
                                <td>{user.email}</td>
                                <td>{user.company}</td>
                                <td>{user.job_title}</td>
                            </tr>
                           ))
                         }
                         </tbody>
                     </table>
                 </div>
            
            
            </>
            
            
        );
    }
}
export default Contact;
