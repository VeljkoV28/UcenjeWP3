import { useEffect, useState } from 'react';
import { Table } from 'react-bootstrap';
import Container from 'react-bootstrap/Container';
import SmjerService from '../..service/SmjerService';



export default function Smjerovi(){
 const [smjerovi, setSmjerovi] = useState();
  
 async function dohvatiSmjerove(){
    await SmjerService.get()
    .then((odg)=>{
      setSmjerovi(odg);

    })
    .catch((e)=>{

    });
 } 

useEffect(()=>{
  dohvatiSmjerove();
},[]);



return(

   <>
   <Container>
     <Table striped bordered hover responsive>
       <thead>
         <tr>
           <th>Naziv</th>
           <th>Trajanje</th>
           <th>Cijena</th>
           <th>Verificiran</th>
         </tr>
       </thead>
       <tbody>
         {smjerovi && smjerovi.map((smjer,index)=>(
           <tr key={index}>
             <td>{smjer.naziv}</td>
             <td>{smjer.trajanje}</td>
             <td>{smjer.cijena}</td>
             <td>{smjer.verificiran}</td>


          </tr> 






         ))}
       </tbody>

     </Table>
   </Container>
   </>


    );

}