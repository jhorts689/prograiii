package com.goowia.swing.gui.listener;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class ButtonListener implements ActionListener {
    @Override
    public void actionPerformed(ActionEvent e) {
        JButton currentButton = (JButton) e.getSource();
        JOptionPane.showMessageDialog(null, "Button Pressed -> " + currentButton.getText());
    }
}
