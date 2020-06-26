package com.swing.hito4.service;

import com.swing.hito4.model.Datamodel;
import com.swing.hito4.repository.Datarepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
@Service
public class DataService implements DataServiceInterface{
private static final String Q_P = "Q,W,E,R,T,Y,U,I,O,P";
private static final String A_L = "A,S,D,F,G,H,J,K,L";
private static final String Z_M = "Z,X,C,V,B,N,M";
@Autowired
private Datarepository datarepository;

@Override
public void saveData() {
        if (datarepository.count() == 0) {
        datarepository.save(new Datamodel(Q_P, "first"));
        datarepository.save(new Datamodel(A_L, "second"));
        datarepository.save(new Datamodel(Z_M, "three"));
        }
        }

@Override
public List<Datamodel> getAllLettersFirst() {
        return datarepository.getFirstRow();
        }

@Override
public List<Datamodel> getAllLettersSecond() {
        return datarepository.getSecondRow();
        }

@Override
public List<Datamodel> getAllLettersThree() {
        return datarepository.getThreeRow();
        }
        }
