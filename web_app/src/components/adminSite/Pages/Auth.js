
import { Container } from 'react-bootstrap'

export default function Auth () {
        return (
            <div>
                <Container className='mt-5' style={{minHeight: "100vh"}}>
                    <h5 className="card-header bg-light text-center">ВХОД В СИСТЕМУ</h5>
                    <form className='p-5 bg-dark text-white'>
                        <div className="form-group row" >
                            <label for="inputEmail3" className="col-sm-2 col-form-label col-form-label-lg">Email</label>
                            <div className="col-sm-10 col-form-label-lg">
                                <input type="email" className="form-control " id="inputEmail3" placeholder="Email"/>
                            </div>
                        </div>
                        <div className="form-group row">
                            <label for="inputPassword3" className="col-sm-2 col-form-label col-form-label-lg">Password</label>
                            <div className="col-sm-10 col-form-label-lg">
                                <input type="password" className="form-control" id="inputPassword3" placeholder="Password"/>
                            </div>
                        </div>
                        {/* <div className="form-group row">
                            <div className="col-sm-2">Checkbox</div>
                            <div className="col-sm-10">
                                <div className="form-check">
                                    <input className="form-check-input" type="checkbox" id="gridCheck1" />
                                    <label className="form-check-label" for="gridCheck1">
                                        Запомнить выбор
                                    </label>
                                </div>
                            </div>
                        </div> */}
                        <div className="form-group row" style={{marginTop: 30}}>
                            <div className="col-sm-10">
                                <button type="submit" className="btn btn-outline-light btn-lg">Войти</button>
                            </div>
                        </div>
                    </form>               
                </Container>
            </div>
        )
}
