import { Button, Col, Container, Form, Row } from "react-bootstrap";
import { Link, useNavigate } from "react-router-dom";
import { RoutesNames } from "../../constants";
import SmjerService from "../../services/SmjerService";


export default function SmjeroviDodaj(){

    const navigate = useNavigate();

    async function dodaj(smjer){
        const odqovor = SmjerService.post(smjer);
        if (odqovor.greska){
            console.log((odqovor).poruka);
            alert('Pogledaj konzolu');
            return;
        }
        navigate(RoutesNames.SMJER_PREGLED);


    }

    function obradiSubmit(e){ // e predstavlja event
        e.preventDefault();
        // alert('Dodajem smjer');

        const podaci = new FormData(e.targeg);

        const smjer = {
        naziv: podaci.get('naziv'),
        trajanje: parseInt(podaci.get('trajanje')),
        cijena: parseFloat(podaci.get('cijena')),
        verificiran: podaci.get('verificiran')== 'on' ? true : false


        };
        // console.log(smjer);
        dodaj(smjer);
    


    }
    

    return (

        <Container>
            <Form onSubmit={obradiSubmit}>
                <Form.Group controlID="naziv">
                    <Form.Label>Naziv</Form.Label>
                    <Form.Control type="text" name="naziv" required />


                 <hr />
                </Form.Group>
                <Form.Group controlID="trajanje">
                    <Form.Label>Trajanje</Form.Label>
                    <Form.Control type="number" name="trajanje"  />


                 <hr />
                </Form.Group>
                <Form.Group controlID="cijena">
                    <Form.Label>Cijena</Form.Label>
                    <Form.Control type="text" name="cijena" />


                 <hr />
                </Form.Group>
                
                
                <Form.Group controlID="verificiran">
                    
                    <Form.Check label="Verificiran" name="verificiran" />


                 <hr />
                </Form.Group>

                



                <Row>
                    <Col xs={7} sm={6} md={3} lg={6} xl={1} xxl={4}>
                        <Link className="btn btn-danger siroko" to={RoutesNames.SMJER_PREGLED}>
                            Odustani
                        </Link>
                    </Col>
                    <Col xs={7} sm={6} md={9} lg={6} xl={1} xxl={4}>
                        <Button className="siroko" variant="primary" type="submit">
                            Dodaj
                        </Button>
                    </Col>
                </Row>

            </Form>
        </Container>

    );
}