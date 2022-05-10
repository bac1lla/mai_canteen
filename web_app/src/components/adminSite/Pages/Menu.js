import React, { Component } from 'react'
import { Container } from 'react-bootstrap'

export default function Menu () {
        return (
            <div>
                <Container className='mt-5' style={{minHeight: "100vh"}}>
                    <h5 className="card-header bg-light text-center">ДОБАВИТЬ БЛЮДО В МЕНЮ</h5>
                    <form className='p-5 bg-dark'>
                        
                        <form className='mt-5'>
                            <div className="input-group mb-3">
                            <label for="inputEmail3" className="col-sm-2 col-form-label text-white col-form-label-lg">Добавьте фото</label>
                                <div className="custom-file bg-light">
                                    <input type="file" className="custom-file-input" id="inputGroupFile02" />
                                    <label className="custom-file-label" for="inputGroupFile02" />
                                </div>
                                <div className="input-group-append card-header">
                                    <button className="btn btn-light" type="button">Загрузить</button>
                                </div>
                            </div>
                        </form>
                        
                        <form className='mt-5'>
                            <div className="row">
                                <div className="col">
                                <input type="text" className="form-control" placeholder="Наименование" />
                                </div>
                                <div className="col">
                                <input type="text" className="form-control" placeholder="Цена" />
                                </div>
                            </div>
                            </form>

                        <form className='mt-5'>
                        <div className="row">
                            <div className="col">
                            <input type="text" className="form-control" placeholder="Ингридиент 1" />
                            </div>
                            <div className="col">
                            <input type="text" className="form-control" placeholder="Ингридиент 2" />
                            </div>
                            <div className="col">
                            <input type="text" className="form-control" placeholder="Ингридиент 3" />
                            </div>
                            <div className="col">
                            <input type="text" className="form-control" placeholder="Ингридиент 4" />
                            </div>
                            <div className="col">
                            <input type="text" className="form-control" placeholder="Ингридиент 5" />
                            </div>
                        </div>
                        </form>
                
                        <div className="col-sm-10 mt-5">
                            <button type="submit" className="btn btn-outline-light btn-lg">СОХРАНИТЬ</button>
                        </div>

                    </form>               
                </Container>
            </div>
        )
    }

