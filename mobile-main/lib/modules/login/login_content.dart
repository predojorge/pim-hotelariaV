import 'package:flutter/material.dart';
import 'package:flutter_bloc/flutter_bloc.dart';

import '../../shared/components/common_field.dart';
import '../../shared/components/custom_snackbar.dart';
import '../../shared/components/password_field.dart';
import '../home/home_page.dart';
import 'login_cubit.dart';
import 'login_state.dart';

class LoginContent extends StatelessWidget {
  final _email = TextEditingController();
  final _pass = TextEditingController();

  LoginContent({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return LayoutBuilder(builder: (context, constraints) {
      return SafeArea(
          child: BlocListener<LoginCubit, LoginState>(
              listener: (context, state) {
                if (state.isLogged) {
                  Navigator.pushReplacementNamed(context, HomePage.route);
                }

                if (state.message != null) {
                  CustomSnackbar.show(context, state.message!);
                }
              },
              child: BlocBuilder<LoginCubit, LoginState>(
                  builder: (context, state) => Stack(
                        children: [
                          Container(
                            height: constraints.maxHeight * .6,
                            decoration: BoxDecoration(
                                color: Colors.white,
                                image: DecorationImage(
                                    fit: BoxFit.fill,
                                    image:
                                        AssetImage("assets/imagemheader.jpg"))),
                            child: Column(
                              mainAxisAlignment: MainAxisAlignment.center,
                              children: [
                                SizedBox(
                                  width: constraints.maxWidth * .5,
                                  child: FittedBox(
                                    fit: BoxFit.fitWidth,
                                    child: Text(
                                      'Valhalla Hotel',
                                      style: TextStyle(
                                        fontWeight: FontWeight.bold,
                                      ),
                                    ),
                                  ),
                                ),
                                Image.asset('assets/logo.png'),
                              ],
                            ),
                          ),
                          Align(
                            alignment: Alignment.bottomCenter,
                            child: ClipRRect(
                              borderRadius: BorderRadius.circular(30),
                              child: Container(
                                height: constraints.maxHeight * .5,
                                color: Colors.white,
                                child: Padding(
                                  padding: const EdgeInsets.all(8.0),
                                  child: SingleChildScrollView(
                                    child: Column(children: [
                                      SizedBox(
                                        height: constraints.maxHeight * .1,
                                      ),
                                      CommonField(
                                          controller: _email,
                                          label: 'E-mail',
                                          keyboardType:
                                              TextInputType.emailAddress),
                                      SizedBox(height: 16),
                                      PasswordField(
                                          controller: _pass, label: 'Senha'),
                                      SizedBox(height: 16),
                                      OutlinedButton(
                                          child: Text(state.isLoading
                                              ? 'AGUARDE...'
                                              : 'ENTRAR'),
                                          onPressed: state.isLoading
                                              ? null
                                              : () =>
                                                  BlocProvider.of<LoginCubit>(
                                                          context)
                                                      .login(
                                                    email: _email.text,
                                                    pass: _pass.text,
                                                  ))
                                    ]),
                                  ),
                                ),
                              ),
                            ),
                          ),
                        ],
                      ))));
    });
  }
}
